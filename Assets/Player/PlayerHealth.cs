using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : Health
{
    public bool Shield = false;
    public GameObject ForceField;
    public float InvisTime = 0.1f;
    private float curInvisTime = 0f;
    public override void Damaged(int Damage) {
        if (curInvisTime >= InvisTime) {
            if (Shield) 
            {
                Shield = false;
                return;
            }
            else {
                base.Damaged(Damage);
                curInvisTime = 0f;
            }
        }
    }
    void Update() {
        if (curInvisTime < InvisTime) {
            curInvisTime += Time.deltaTime;
        }
        if (Shield) {
            ForceField.SetActive(true);
        }
        else {
            ForceField.SetActive(false);
        }
    }
}
