using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static int timeLeft;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        timeLeft = 20;
        InvokeRepeating("ReduceTime", 1, 1);
    }
    void ReduceTime()
    {
        if (timeLeft <= 1)
        {
            Debug.Log("game over");
            SceneManager.LoadScene("GameOver");
            Destroy(this.gameObject);
        }
        else
        {
            timeLeft -= 1;
        }
    }
}
