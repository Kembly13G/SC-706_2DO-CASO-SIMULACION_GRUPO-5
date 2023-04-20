using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GemsController : MonoBehaviour
{
    [SerializeField]
    float gems = 1;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Player3DController controller = other.GetComponent<Player3DController>();
            controller.GemsCollected(gems);
            Destroy(gameObject);
        }
    }
}