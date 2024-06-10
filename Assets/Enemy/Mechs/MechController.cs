using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechController : MonoBehaviour
{
    public Attack[] attacks;
    private float curTime = -5f;
    public float maxTime = 1f;
    public float HowOftenToDecrease = 5f;
    public float AmountToDecreaseBy = 0.05f;
    private float curDecreaseTime;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > maxTime) {
            Attack();
            curTime = 0f;
        }
        curDecreaseTime += Time.deltaTime;
        if (curDecreaseTime > HowOftenToDecrease) {
            curDecreaseTime = 0f;
            maxTime -= AmountToDecreaseBy;
        }
    }
    public void Attack() {
        attacks[Random.Range(0,attacks.Length)].CallAttack();
    }
}
