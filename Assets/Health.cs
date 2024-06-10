using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int CurHealth;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public virtual void Damaged(int Damage) {
        CurHealth -= Damage;
        if (CurHealth <= 0) {
            Died();
        }
    }
    public virtual void Died() {
        Destroy(gameObject);    
    }
}
