using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    float TimeToLose=120;
   public void Win()
    {
        SceneManager.LoadScene(2);
    }
    public void Lose()
    {
        SceneManager.LoadScene(1);
    }
    private void Update()
    {
        TimeToLose -= Time.deltaTime;
        if (TimeToLose <= 0)
        {
            Lose();
        }
    }
}
