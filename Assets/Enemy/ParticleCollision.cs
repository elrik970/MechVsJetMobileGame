using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleCollision : MonoBehaviour
{
    public int Damage;
    public ParticleSystem part;
    void Start()
    {
        part = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject col) {
        List<ParticleCollisionEvent> collisionEvents = new List<ParticleCollisionEvent>();
        int numCollisionEvents = part.GetCollisionEvents(col, collisionEvents);
        for (int i = 0; i < numCollisionEvents;i++) {
            col.GetComponent<Health>()?.Damaged(Damage);
        }
    }
}
