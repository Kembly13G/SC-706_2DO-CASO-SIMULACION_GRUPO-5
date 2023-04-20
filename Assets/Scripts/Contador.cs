using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    [SerializeField]
    GameObject Player;
    [SerializeField]
    Text Gems;
    void Update()
    {
        Gems.text=Player.GetComponent<Player3DController>().GetGemsCollected().ToString()+"/12 Gems";
    }
}