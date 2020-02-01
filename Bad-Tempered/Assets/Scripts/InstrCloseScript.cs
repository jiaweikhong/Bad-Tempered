using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstrCloseScript : MonoBehaviour
{
    public GameObject startButton;
    public GameObject instructionsButton;
    public AudioSource closeInstrSource;
    public AudioClip closeInstrClip;
    // Start is called before the first frame update
    void Start()
    {
        closeInstrSource = GetComponent<AudioSource>();
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
