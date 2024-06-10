using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour
{
    public float CardCount;
    public List<string> CardNames;
    public List<GameObject> CardObjects;
    public List<string> OwnedCards;
    public Dictionary<string, GameObject> CardToGameObject = new Dictionary<string, GameObject>();
    void Awake()
    {
        for (int i = 0; i < CardNames.Count; i++) {
            CardToGameObject.Add(CardNames[i],CardObjects[i]);
        }
        
    }
    void Start() {

    }

    
    void Update()
    {

    }
    public GameObject GetCard(string name) {
        return CardToGameObject[name];
    }
    public List<GameObject> GetAllOwnedCards() {
        List<GameObject> AllOwnedCards = new List<GameObject>();
        foreach (string CardName in OwnedCards) {
            AllOwnedCards.Add(GetCard(CardName));
        }
        return AllOwnedCards;
    }
}
