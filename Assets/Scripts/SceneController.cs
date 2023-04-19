using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public void Win()
    {
        SceneManager.LoadScene(2);
    }
    public void Lose()
    {
        SceneManager.LoadScene(1);
    }
}
