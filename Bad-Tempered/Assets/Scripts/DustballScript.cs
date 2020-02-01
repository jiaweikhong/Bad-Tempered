using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustballScript : MonoBehaviour
{
    GameObject screen;

    // Start is called before the first frame update
    void Start()
    {
        screen = GameObject.FindGameObjectWithTag("Screen");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseEnter()
    {
        screen.GetComponent<CleanStageMaster>().IncreaseCleanCount();
        gameObject.SetActive(false);
    }
}
