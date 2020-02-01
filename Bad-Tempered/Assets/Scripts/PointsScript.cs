using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsScript : MonoBehaviour
{
    public static int points;

    void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        points = 0;
    }
}
