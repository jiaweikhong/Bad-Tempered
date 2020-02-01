using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public void GoToPrepareGame()
    {
        SceneManager.LoadScene("PrepareGame");
    }
    public void GoToCrackedStage()
    {
        SceneManager.LoadScene("CrackedStage");
    }
    public void GoToCleanStage()
    {
        SceneManager.LoadScene("CleanStage");
    }
    public void GoToPasteStage()
    {
        SceneManager.LoadScene("PasteStage");
    }

    public void GoToCheckStage()
    {
        SceneManager.LoadScene("CheckStage");
    }

    public void GoToExtraDustStage()
    {
        SceneManager.LoadScene("ExtraDustStage");
    }
}
