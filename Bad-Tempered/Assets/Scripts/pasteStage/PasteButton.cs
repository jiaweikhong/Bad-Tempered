using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PasteButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float timeMouseDown = 0.0f;
    public static bool mouseIsDown;
    public ScreenProtector screenProtector;
    //SpriteRenderer m_SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (mouseIsDown == true)
        {
            timeMouseDown += Time.deltaTime;
            Color tmpColor = gameObject.GetComponent<Image>().color;
            tmpColor.a = 0.4f;
            gameObject.GetComponent<Image>().color = tmpColor;
            if (timeMouseDown > 1.0f)
            {
                screenProtector.showScore = true;
            }
            else
            {

            }
        }
        else
        {
            timeMouseDown = 0.0f;
            Color tmpColor = gameObject.GetComponent<Image>().color;
            tmpColor.a = 1.0f;
            gameObject.GetComponent<Image>().color = tmpColor;
        }
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        mouseIsDown = true;
        
    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {
        mouseIsDown = false;
    }
}
