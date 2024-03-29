﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeelScript : MonoBehaviour
{
    GameObject pointer;
    public int peelType;
    public Animator animator;
    public AudioSource peelAttemptSound;

    // Start is called before the first frame update
    void Start()
    {
        peelAttemptSound = GetComponent<AudioSource>();
        pointer = GameObject.FindGameObjectWithTag("CrackedPointer");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        peelAttemptSound.Play();
        animator.SetBool("PeelButtonDown", true);
        if (peelType == 1)
        {
            pointer.GetComponent<CrackedScreenPointer>().OnPress();
        }
        else
        {
            pointer.GetComponent<NewScreenPointer>().OnPress();
        }
    }

    private void OnMouseUp()
    {

        animator.SetBool("PeelButtonDown", false);
        if (peelType == 1)
        {
            pointer.GetComponent<CrackedScreenPointer>().OnRelease();
        }
        else
        {
            pointer.GetComponent<NewScreenPointer>().OnRelease();
        }
    }
}
