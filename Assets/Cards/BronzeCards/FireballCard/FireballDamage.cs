using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballDamage : MonoBehaviour
{
    public int Damage = 2;
    public GameObject ExplosionFX;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag != "Player" && col.gameObject.tag != "PlayerAttack") {
            Health EnemyHealth = col.gameObject.GetComponent<Health>();
            if (EnemyHealth) {
                EnemyHealth.Damaged(Damage);
            }
            GameObject.Instantiate(ExplosionFX,transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
