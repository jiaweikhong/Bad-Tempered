using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        //animator.SetBool("ButtonPress", true);
    }

    private void OnMouseUp()
    {
        //animator.SetBool("ButtonPress", false);
        GoToPrepareGame();
    }

    public void GoToPrepareGame()
    {
        SceneManager.LoadScene("PrepareGame");
    }
}
