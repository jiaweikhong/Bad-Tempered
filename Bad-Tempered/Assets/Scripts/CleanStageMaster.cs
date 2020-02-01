using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CleanStageMaster : MonoBehaviour
{
    private int cleanCount;
    public int totalDustCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cleanCount >= totalDustCount)
        {
            GoToPasteStage();
        }
    }

    public void IncreaseCleanCount()
    {
        cleanCount += 1;
        //Debug.Log("cleancount up");
    }

    public void GoToPasteStage()
    {
        SceneManager.LoadScene("PasteStage");
    }
}
