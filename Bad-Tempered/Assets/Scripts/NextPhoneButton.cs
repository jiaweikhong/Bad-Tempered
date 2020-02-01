using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPhoneButton : MonoBehaviour
{
    public Animator animator;
    public AudioSource buttonPressSound;
    // Start is called before the first frame update
    void Start()
    {
        buttonPressSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoToCrackedStage()
    {
        SceneManager.LoadScene("CrackedStage");
    }

    private void OnMouseDown()
    {
        Debug.Log("hey");
        buttonPressSound.Play();
        animator.SetTrigger("ButtonPress");
    }
}
