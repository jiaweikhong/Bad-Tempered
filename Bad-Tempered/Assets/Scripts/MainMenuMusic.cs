using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    public AudioSource mainmenuMusic;
    // Start is called before the first frame update
    void Start()
    {
        mainmenuMusic = GetComponent<AudioSource>();
        mainmenuMusic.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
