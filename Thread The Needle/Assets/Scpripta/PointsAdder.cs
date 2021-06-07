using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsAdder : MonoBehaviour
{
    public Score text;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit");

        text.score = text.score + 1;

    }

}
