using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public AudioSource buttonPress;
    public Sprite releasedButtonImg;
    public Sprite pressedButtonImg;
    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        buttonPress = GetComponent<AudioSource>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = releasedButtonImg;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        spriteRenderer.sprite = pressedButtonImg;
        buttonPress.Play();
        //animator.SetBool("ButtonPress", true);
    }

    private void OnMouseUp()
    {
        //animator.SetBool("ButtonPress", false);
        spriteRenderer.sprite = releasedButtonImg;
        GameObject.FindGameObjectWithTag("InGameMusic").GetComponent<AudioSource>().Play();
        GoToPrepareGame();
    }

    public void GoToPrepareGame()
    {
        
        SceneManager.LoadScene("PrepareGame");
    }
}
