using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SprayAttack : Attack
{
    public ParticleSystem ps;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void CallAttack() {
        ps.Play();
    }
}
