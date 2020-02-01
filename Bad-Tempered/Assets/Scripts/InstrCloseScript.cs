using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrCloseScript : MonoBehaviour
{
    public GameObject startButton;
    public GameObject instructionsButton;

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
        this.gameObject.SetActive(false);
        startButton.SetActive(true);
        instructionsButton.SetActive(true);
    }
}
