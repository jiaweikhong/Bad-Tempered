﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = PointsScript.points.ToString();
    }
}
