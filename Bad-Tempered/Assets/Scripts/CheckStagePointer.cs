﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckStagePointer : MonoBehaviour
{
    private bool shouldLerp;
    private bool lerpUp;
    private bool lerpDown;
    private float upperBound = 0.625f;
    private float lowerBound = 0.375f;
    public float lerpTime;
    public float pointerSpeed = 2f;

    private Vector2 startPosition;
    private Vector2 endPosition;

    public GameObject topRef;

    // Start is called before the first frame update
    void Start()
    {
        lerpUp = true;
        startPosition = this.transform.position;
        endPosition = topRef.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // check if pointer should lerp
        if (shouldLerp == true)
        {
            // handle bouncing back and forth
            if (lerpTime >= 1f)
            {
                if (lerpUp == true)
                {
                    lerpUp = false;
                    lerpDown = true;
                    lerpTime = 0f;
                }
                else if (lerpDown == true)
                {
                    lerpDown = false;
                    lerpUp = true;
                    lerpTime = 0f;
                }
            }
            // handle moving
            if (lerpUp)
            {
                lerpTime += Time.deltaTime * pointerSpeed;
                transform.position = Vector2.Lerp(startPosition, endPosition, lerpTime);
            }
            else if (lerpDown)
            {
                lerpTime += Time.deltaTime * pointerSpeed;
                transform.position = Vector2.Lerp(startPosition, endPosition, 1 - lerpTime);
            }
        }
        else
        {
            transform.position = Vector2.Lerp(startPosition, endPosition, 0);
        }
    }

    public void OnPress()
    {
        shouldLerp = true;
    }

    public void OnRelease()
    {
        shouldLerp = false;
        if (lerpTime <= upperBound && lerpTime >= lowerBound)
        {
            GoToExtraDustStage();
        }
        /*  else
          {
              upperBound *= 0.75f;
              lowerBound *= 0.75f;
          }*/
        lerpTime = 0f;
        lerpUp = true;
        lerpDown = false;
    }
    public void GoToExtraDustStage()
    {
        SceneManager.LoadScene("ExtraDustStage");
    }
}