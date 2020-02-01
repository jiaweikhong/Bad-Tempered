using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    //public GameObject cursor;
    private Vector2 mousePos;
    public AudioSource wipeSound;
    public AudioClip wipeSoundClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        if (transform.position.x == mousePos.x && transform.position.y == mousePos.y)
        {

        }
        else
        {
            if (!wipeSound.isPlaying)
            {
                float randVol = Random.Range(0.5f, 2.0f);
                wipeSound.PlayOneShot(wipeSoundClip, randVol);
            }
        }
        transform.position = mousePos;
    }

    /*private void OnMouseDown()
    {
        Debug.Log("hey");
    }*/
}
