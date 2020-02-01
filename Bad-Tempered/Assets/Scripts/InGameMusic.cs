using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMusic : MonoBehaviour
{
    public AudioSource ingamemusic;
    // Start is called before the first frame update
    void Awake()
    {
        ingamemusic = GetComponent<AudioSource>();
        if (!ingamemusic.isPlaying)
        {
            ingamemusic.Play();
        }

        GameObject[] objs = GameObject.FindGameObjectsWithTag("InGameMusic");
        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
