using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float myTimer = 120;
    public Text timerText;
    private bool timerIsActive = true;

    void Start()
    {
        timerText = GetComponent<Text>();
    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Update()
    {
        if (timerIsActive)
        {
            myTimer -= Time.deltaTime;
            timerText.text = myTimer.ToString("f0");
            print(myTimer);

            if (myTimer <= 0)
            {
                myTimer = 0;
                timerIsActive = false;
                SceneManager.LoadScene("lose");

            }
        }

    }
}
