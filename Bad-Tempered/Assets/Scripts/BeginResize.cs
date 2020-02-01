using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginResize : MonoBehaviour
{
    private bool shouldLerp;
    public float lerpTime;
    public float lerpSpeed = 1f;
    private Vector2 startPosition;
    private Vector3 startScale;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        startScale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldLerp == true)
        {
            lerpTime += Time.deltaTime * lerpSpeed;
            transform.position = Vector2.Lerp(startPosition, new Vector2(0f,0f), lerpTime);
            transform.localScale = Vector3.Lerp(startScale, new Vector3(0.5f, 0.5f), lerpTime);
        }
        if (lerpTime >= 1f)
        {
            SceneManager.LoadScene("CrackedStage");
        }
    }

    public void StartLerp()
    {
        shouldLerp = true;
    }
}
