using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrackedScreenAnimate : MonoBehaviour
{
    public int anim;
    public Animator animator;
    public AudioSource peelSound;
    // Start is called before the first frame update
    void Start()
    {
        peelSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (anim)
        {
            case 1:
                if (!peelSound.isPlaying)
                {
                    peelSound.Play();
                } 
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
        PointsScript.points += 20;
        SceneManager.LoadScene("CleanStage");
    }
}
