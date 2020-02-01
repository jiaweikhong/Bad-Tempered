using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public Animator animator;
    public AudioSource buttonPress;

    // Start is called before the first frame update
    void Start()
    {
        buttonPress = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        buttonPress.Play();
        //animator.SetBool("ButtonPress", true);
    }

    private void OnMouseUp()
    {
        //animator.SetBool("ButtonPress", false);
        GameObject.FindGameObjectWithTag("InGameMusic").GetComponent<AudioSource>().Play();
        GoToPrepareGame();
    }

    public void GoToPrepareGame()
    {
        SceneManager.LoadScene("PrepareGame");
    }
}
