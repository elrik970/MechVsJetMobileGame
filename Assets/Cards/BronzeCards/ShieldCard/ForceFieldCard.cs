using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldCard : Card
{
    public override void CardActivate() {
        Energy energy = Player.GetComponent<Energy>();
        if (energy.EnergyAmount >= energyCost) {
            Player.GetComponent<PlayerHealth>().Shield = true;

            energy.EnergyAmount -= energyCost;

            base.CardActivate();
        }

        
    }
}
