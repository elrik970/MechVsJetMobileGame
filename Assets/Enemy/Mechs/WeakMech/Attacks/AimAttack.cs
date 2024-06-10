using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimAttack : Attack
{
    public GameObject Player;
    public ParticleSystem ps;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        ps = GetComponent<ParticleSystem>();
    }
    void Update()
    {
        
    }
    public override void CallAttack() {
        Vector3 pos = ps.transform.position;
        Vector3 playerPos = Player.transform.position;
        ps.transform.position = new Vector3(pos.x,playerPos.y,pos.z);
        ps.Play();
    }
}
