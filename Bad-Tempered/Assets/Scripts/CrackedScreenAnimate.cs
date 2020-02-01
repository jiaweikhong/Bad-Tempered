using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrackedScreenAnimate : MonoBehaviour
{
    public int anim;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (anim)
        {
            case 1:
                Debug.Log("success!");
                animator.SetTrigger("successPeel");
                break;
            /*case 2:
                Debug.Log("fail!");
                //animator.SetTrigger("failurePeel");
                animator.Play("CrackedScreenSuccessPeel", -1, 0f);
                break;*/
        }
    }
    public void GoToCleanStage()
    {
        SceneManager.LoadScene("CleanStage");
    }
}
