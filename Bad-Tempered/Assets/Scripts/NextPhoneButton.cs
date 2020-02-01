using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPhoneButton : MonoBehaviour
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

    public void GoToCrackedStage()
    {
        SceneManager.LoadScene("CrackedStage");
    }

    private void OnMouseDown()
    {
        Debug.Log("hey");
        animator.SetTrigger("ButtonPress");
    }
}
