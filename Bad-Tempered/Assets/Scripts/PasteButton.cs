﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PasteButton : MonoBehaviour
{
    private int finalScore;
    float timeMouseDown = 0.0f;
    public static bool mouseIsDown;
    public ScreenProtector screenProtector;
    public Sprite PressedButtonImg;
    public Sprite NormalButtonImg;
    SpriteRenderer spriteRenderer;
    public AudioSource pasteSound;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = NormalButtonImg;
    }
    // Update is called once per frame
    void Update()
    {
        if (mouseIsDown == true)
        {
            Debug.Log("MouseDown!");
            timeMouseDown += Time.deltaTime;
            spriteRenderer.sprite = PressedButtonImg;
            if (timeMouseDown > 1.0f)
            {
                screenProtector.isPastedOn = true;
                finalScore = Mathf.RoundToInt(ScreenProtector.score);
                PointsScript.points += finalScore;
                mouseIsDown = false;
                SceneManager.LoadScene("CheckStage");
            }
            else
            {

            }
        }
        else
        {
            timeMouseDown = 0.0f;
            spriteRenderer.sprite = NormalButtonImg;

        }
    }


    private void OnMouseDown()
    {
        pasteSound.Play();
        mouseIsDown = true;
    }

    private void OnMouseUp()
    {
        mouseIsDown = false;
    }

}
