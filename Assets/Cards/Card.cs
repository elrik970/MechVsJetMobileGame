using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Card : MonoBehaviour
{
    public GameObject Player;
    public int energyCost;
    public int index;
    public CurrentHand CurrentHand;
    void Start() {
        Player = GameObject.FindWithTag("Player");
        CurrentHand = GameObject.FindWithTag("CurHand")?.GetComponent<CurrentHand>();
    }
    public virtual void CardActivate() {
        CurrentHand.PlayedCard(index);
    }
}   
