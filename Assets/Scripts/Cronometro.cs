using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cronometro : MonoBehaviour
{
    //Declaración de variables
    [SerializeField]
    Text TimeText;
    [SerializeField]
    float tiempo = 120;

    // Update is called once per frame
    void Update()
    {
        tiempo -= Time.deltaTime;
        TimeText.text=Mathf.FloorToInt(tiempo)+"";
    }

    
}