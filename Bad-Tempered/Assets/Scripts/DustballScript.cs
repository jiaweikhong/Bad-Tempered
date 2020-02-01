using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustballScript : MonoBehaviour
{
    GameObject screen;
    Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.FindGameObjectWithTag("Screen");
        col = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*for (var i = 0; i < Input.touchCount; ++i)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began)
            {
                RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);
                // RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
                if (hitInfo)
                {
                    Debug.Log(hitInfo.transform.gameObject.name);
                    // Here you can check hitInfo to see which collider has been hit, and act appropriately.
                }
            }
        }*/

        /*if (Input.touchCount > 0)
        {            
            Debug.Log("touch detected");
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);



            if (touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if (col == touchedCollider)
                {
                    screen.GetComponent<CleanStageMaster>().IncreaseCleanCount();
                    gameObject.SetActive(false);
                }
            }
        }*/
    }

    /*private void OnMouseDown()
    {
        Debug.Log("mouse down");
        screen.GetComponent<CleanStageMaster>().IncreaseCleanCount();
        gameObject.SetActive(false);
    }*/
    /*private void OnMouseOver()
    {
        Debug.Log("mouse over");
        gameObject.SetActive(false);
    }*/
    private void OnMouseEnter()
    {
        Debug.Log("mous enter");
        screen.GetComponent<CleanStageMaster>().IncreaseCleanCount();
        gameObject.SetActive(false);
    }
    /*private void OnMouseDrag()
    {
        Debug.Log("mouse drag");
        screen.GetComponent<CleanStageMaster>().IncreaseCleanCount();
        gameObject.SetActive(false);
    }*/
}
