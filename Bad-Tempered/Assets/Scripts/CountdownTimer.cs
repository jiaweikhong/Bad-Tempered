using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public static int timeLeft;
    public AudioSource countdownSignal;
    public AudioClip countdownDing;
    void Start()
    {
        countdownSignal = GetComponent<AudioSource>();
        DontDestroyOnLoad(transform.gameObject);
        timeLeft = 20;
        InvokeRepeating("ReduceTime", 1, 1);
    }
    void ReduceTime()
    {
        if (timeLeft == 4)
        {
            countdownSignal.PlayOneShot(countdownDing, 1.0f);
        } else if (timeLeft == 3)
        {
            countdownSignal.PlayOneShot(countdownDing, 2.0f);
        } else if (timeLeft == 2)
        {
            countdownSignal.PlayOneShot(countdownDing, 3.0f);
        }
        
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
