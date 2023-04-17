using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController: MonoBehaviour
{
    [SerializeField]
    float rotationSpeed = 100f; 
    float rotationAngle=0f;

    void Update()
    {
        rotationAngle += rotationSpeed * Time.deltaTime;
        if ((rotationAngle >= 360f)||(rotationAngle < 0f))
        {
            rotationAngle = 0f;
        }

        transform.rotation = Quaternion.Euler(transform.rotation.x, rotationAngle, transform.rotation.z );
    }
}
