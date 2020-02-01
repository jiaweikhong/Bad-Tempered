using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public Animator animator;
    public AudioSource buttonPressSound;
    public AudioClip buttonPressSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        buttonPressSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        animator.SetBool("ButtonPress", true);
        buttonPressSound.PlayOneShot(buttonPressSoundClip, 1.0f);
    }

    private void OnMouseUp()
    {
        animator.SetBool("ButtonPress", false);
        buttonPressSound.PlayOneShot(buttonPressSoundClip, 1.0f);
        GoToPrepareGame();
    }

    public void GoToPrepareGame()
    {
        SceneManager.LoadScene("PrepareGame");
    }
}
