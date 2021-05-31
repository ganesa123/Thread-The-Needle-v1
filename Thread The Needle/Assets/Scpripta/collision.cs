using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter()
    {
        Debug.Log("Hey 6 Feet!!");
        movement.enabled = false;
    }
}
