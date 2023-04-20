using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoliceController : MonoBehaviour
{
    public float countdownTime = 5f;
    private bool playerInsideArea = false;
    private float timeLeft;


    void Update()
    {
        if (playerInsideArea) {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f) {
                 FindObjectOfType<GameManage>().GameOver();
                Debug.Log("Has perdido el juego");
            }
        }
    }

 void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            playerInsideArea = true;
            timeLeft = countdownTime;
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            playerInsideArea = false;
        }
    }
}



