using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentHand : CardDeck
{
    public List<GameObject> SpawnedCards = new List<GameObject>();
    public CardDeck DrawPile;
    public CardDeck DiscardPile;
    public CardHandler CardHandler;
    void Start()
    {
        DrawPile = GetComponent<DrawPile>();
        DiscardPile = GetComponent<DiscardPile>();
        
        GameObject cardHandlerObject = GameObject.FindWithTag("CardHandler");
        
        CardHandler = cardHandlerObject.GetComponent<CardHandler>();
        
        DrawPile.Cards = CardHandler.GetAllOwnedCards();

        int i = 0;
        while (i < 3) {
            int index = Random.Range(0,DrawPile.Cards.Count);
            Add(DrawPile.Cards[index]);
            DrawPile.Remove(index);
            i++;
        }
        SpawnedCards = new List<GameObject>();
        for (i = 0; i < Cards.Count; i++) {
            AddPlayableCard(Cards[i],i);
            SpawnedCards.Add(Cards[i]);
        }
        
    }

    void Update()
    {
        UpdateCards();
    }
    public void UpdateCards() {
        int count = transform.childCount;
        for(int i = 0; i < count; i++) {
            Transform child = transform.GetChild(i);
            if (SpawnedCards[i] != Cards[i]) {
                Destroy(child.GetChild(0).gameObject);
                GameObject Card = AddPlayableCard(Cards[i], i);
                SpawnedCards[i] = Cards[i];

                
                
            }
        }
    }
    public GameObject AddPlayableCard(GameObject CardToPlay, int index) {
        GameObject Card = (GameObject)GameObject.Instantiate(CardToPlay,Vector3.zero,Quaternion.identity);
        Card.transform.SetParent(transform.GetChild(index),false);
        Card.transform.localPosition = Vector3.zero;

        Button cardButton = transform.GetChild(index).gameObject.GetComponent<Button>();
        cardButton.targetGraphic = Card.GetComponent<Image>();

        Card.GetComponent<Card>().index = index;

        return Card;
    }
    public GameObject PlayedCard(int index) {
        GameObject removed = Remove(index);

        DiscardPile.Add(removed);

        if (DrawPile.Cards.Count == 0) {
            while (DiscardPile.Cards.Count > 0) {
                int i = Random.Range(0,DiscardPile.Cards.Count);
                DrawPile.Add(DiscardPile.Cards[i]);
                DiscardPile.Remove(i);
            }
        }

        GameObject newCard = DrawPile.Remove(DrawPile.Cards.Count-1);

        Cards.Insert(index,newCard);

        return removed;

    }
}
