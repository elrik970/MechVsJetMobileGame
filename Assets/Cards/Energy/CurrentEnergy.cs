using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentEnergy : MonoBehaviour
{
    public GameObject Player;
    public TMPro.TMP_Text text;
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        text.text = (Player.GetComponent<Energy>().EnergyAmount).ToString();
    }
}
