using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore : MonoBehaviour
{
    public static int scoreValue = 0;
    TextMesh score;

    void Start()
    {
        score = GetComponent<TextMesh>();
    }

    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
