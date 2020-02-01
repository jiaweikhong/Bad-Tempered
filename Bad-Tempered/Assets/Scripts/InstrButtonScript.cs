using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstrButtonScript : MonoBehaviour
{
    public Animator animator;
    public GameObject instructions;
    public GameObject startButton;
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
        animator.SetBool("InstrButtonDown", true);
        //Button sound buggy if repeatedly do on pc. test on com first.
        buttonPressSound.PlayOneShot(buttonPressSoundClip, 1.0f);
    }

    private void OnMouseUp()
    {
        animator.SetBool("InstrButtonDown", false);
        buttonPressSound.PlayOneShot(buttonPressSoundClip, 1.0f);
        instructions.SetActive(true);
        startButton.SetActive(false);
        //this.gameObject.SetActive(false);
        //GoToInstrPage();
    }

    /*public void GoToInstrPage()
    {
        SceneManager.LoadScene("InstrPage");
    }*/

}
