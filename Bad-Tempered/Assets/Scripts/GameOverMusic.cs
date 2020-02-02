using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMusic : MonoBehaviour
{
    public AudioSource gameoverMusic;
    public InGameMusic ingameMusic;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject.FindGameObjectWithTag("InGameMusic").GetComponent<AudioSource>().Stop();
        Destroy(GameObject.FindGameObjectWithTag("InGameMusic"));
        gameoverMusic = GetComponent<AudioSource>();
        gameoverMusic.Play();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
