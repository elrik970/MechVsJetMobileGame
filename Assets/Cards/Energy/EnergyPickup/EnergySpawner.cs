using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySpawner : MonoBehaviour
{
    public float SpawnTime = 1f;
    private float curTime = 0f;
    public GameObject EnergyGameObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curTime += Time.deltaTime;
        if (curTime > SpawnTime) {
            curTime = 0f;
            GameObject.Instantiate(EnergyGameObject,new Vector3(-4.4f,Random.Range(-3f,3f)),Quaternion.identity);
        }
    }
}
