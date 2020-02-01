using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButton : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite releasedButtonImg;
    public Sprite pressedButtonImg;
    public AudioSource buttonPressSound;
    public AudioClip buttonPressClip;
    SpriteRenderer spriteRenderer;


    void Start()
    {
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
        buttonPressSound.Play();
 
    }

    private void OnMouseUp()
    {
        spriteRenderer.sprite = releasedButtonImg;
        buttonPressSound.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
