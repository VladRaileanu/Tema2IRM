using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cosEvent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ShowScore.scoreValue += 1;
    }
}
