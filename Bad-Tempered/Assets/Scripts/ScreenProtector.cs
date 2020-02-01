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
    //float timeBenchmark = 3.0f;
    //float timeElapsed = 0.0f;
    float maxScore = 60.0f;
    public static float score = 0.0f;
    public bool isPastedOn = false;
    SpriteRenderer m_SpriteRenderer;
    float yellowRange = 1.0f;
    float greenRange = 0.1f;
    float deductScoreMultiplier = 3.0f;
    public SpriteRenderer backing;
    public AudioClip greenAlert;
    public AudioClip yellowAlert;
    public AudioClip redAlert;
    public AudioSource alertSignal;
    float penalty = 0.0f;
    //If stage completed within 3 secs, no airbubbles
    //Else for every sec elapsed after 3 secs,+1 airbubble for next stage.


    // Start is called before the first frame update

    void Start()
    {
        //Timer for 3 seconds start!
        transform.position = new Vector3(1.0f, 1.0f, 0);
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_SpriteRenderer.color = Color.magenta;
        alertSignal = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 newPos = Vector3.zero;
        
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
            penalty = 0;
            

        } else if (transform.position.x < yellowRange && transform.position.x > -yellowRange && transform.position.y < yellowRange && transform.position.y > -yellowRange)
        {
            m_SpriteRenderer.color = Color.yellow;
            penalty = 20;
        } else
        {
            m_SpriteRenderer.color = Color.magenta;
            penalty = 40;
        }
        if (!alertSignal.isPlaying)
        {
            if (m_SpriteRenderer.color == Color.green)
            {
                alertSignal.PlayOneShot(greenAlert, 0.5f);
            }
            else if (m_SpriteRenderer.color == Color.yellow)
            {
                alertSignal.PlayOneShot(yellowAlert, 0.5f);
            }
            else if (m_SpriteRenderer.color == Color.magenta)
            {
                alertSignal.PlayOneShot(redAlert, 0.5f);
            }
        }
        score = maxScore - (Mathf.Abs(transform.position.x) * deductScoreMultiplier) - Mathf.Abs(transform.position.y) - penalty;
        if (score < 0)
        {
            score = 0;
        }
    }

}
