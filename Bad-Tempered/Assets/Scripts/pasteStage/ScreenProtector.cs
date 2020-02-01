using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScreenProtector : MonoBehaviour
{
    float speed = 1.0f;
    float boundX = 6.0f;
    float boundY = 10.0f;
    float timeBenchmark = 3.0f;
    float timeElapsed = 0.0f;
    float maxScore = 60.0f;
    public static float score = 0.0f;
    public bool showScore = false;
    SpriteRenderer m_SpriteRenderer;
    float yellowRange = 1.0f;
    float greenRange = 0.05f;
    float deductScoreMultiplier = 3.0f;
    public Text scoreText;

    //If stage completed within 3 secs, no airbubbles
    //Else for every sec elapsed after 3 secs,+1 airbubble for next stage.


    // Start is called before the first frame update

    void Start()
    {
        //Timer for 3 seconds start!
        transform.position = new Vector3(1.0f, 1.0f, 0);
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.red;
        

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPos = Vector3.zero;
        //Use coroutines to segment parts of the game
        //1st coroutine is the alignment of the screen protector. If position hit, go to next coroutine
        //2nd coroutine ensures alignment of screenprotector is at (0,0) for 1 sec. If completed, prompt to go next stage appears?(tap enabled) Else,go back to 1st coroutine
        //Calculate and bring over the number of air bubbles to be generated in the next stage.
        float inputX = Input.acceleration.x * speed;
        float inputY = Input.acceleration.y * speed;
        Vector3 tempPos = new Vector3(transform.position.x + inputX, transform.position.y + inputY);

        // Prevent screen protector from going out of bounds
        if (tempPos.x > boundX || tempPos.x < -boundX || tempPos.y > boundY || tempPos.y < -boundY)
        {
            //Do Nothing
        }
        else
        {
            transform.position = tempPos;
        }

        // Check how accurate user places the screen protector.
        
        if (transform.position.x < greenRange && transform.position.x > -greenRange && transform.position.y < greenRange && transform.position.y > -greenRange)
        {
            m_SpriteRenderer.color = Color.green;
        } else if (transform.position.x < yellowRange && transform.position.x > -yellowRange && transform.position.y < yellowRange && transform.position.y > -yellowRange)
        {
            m_SpriteRenderer.color = Color.yellow;
        } else
        {
            m_SpriteRenderer.color = Color.red;
        }
        score = maxScore - (Mathf.Abs(transform.position.x) * deductScoreMultiplier) - Mathf.Abs(transform.position.y);
        if (showScore == true)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

}
