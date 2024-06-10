using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDeck : MonoBehaviour
{
    public List<GameObject> Cards = new List<GameObject>();
    public virtual void Add(GameObject Card) {
        Cards.Add(Card);
    }
    public virtual GameObject Remove(int index = 0) {
        GameObject removed = Cards[index];
        Cards.RemoveAt(index);
        return removed;
    }
}
