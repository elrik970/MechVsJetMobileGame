using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float TimeTillDestroy;
    void Start()
    {
        Destroy(gameObject,TimeTillDestroy);
    }
}
