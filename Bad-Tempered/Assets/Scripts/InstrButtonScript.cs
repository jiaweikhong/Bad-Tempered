using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InstrButtonScript : MonoBehaviour
{
    public Animator animator;
    public GameObject instructions;
    public GameObject startButton;

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
        animator.SetBool("InstrButtonDown", true);
    }

    private void OnMouseUp()
    {
        animator.SetBool("InstrButtonDown", false);
        instructions.SetActive(true);
        startButton.SetActive(false);
        this.gameObject.SetActive(false);
        //GoToInstrPage();
    }

    /*public void GoToInstrPage()
    {
        SceneManager.LoadScene("InstrPage");
    }*/

}
