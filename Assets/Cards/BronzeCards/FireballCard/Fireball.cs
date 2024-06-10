using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : Card
{
    public GameObject FireballObject;
    public override void CardActivate() {
        Energy energy = Player.GetComponent<Energy>();
        if (energy.EnergyAmount >= energyCost) {
            GameObject ball = (GameObject)GameObject.Instantiate(FireballObject,Vector3.zero, Quaternion.identity);
            ball.transform.SetParent(Player.transform);
            ball.transform.localPosition = new Vector3(0.5f,0f,0f);

            energy.EnergyAmount -= energyCost;
            
            base.CardActivate();
        }
        
    }
}
