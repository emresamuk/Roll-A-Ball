using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraKontrol : MonoBehaviour
{
    public GameObject top;

    Vector3 aradakiMesafe;

    // Use Awake or Start, not both, depending on your needs
    void Awake()
    {
        // Check if 'top' is assigned
        if (top == null)
        {
            Debug.LogError("Top referansi eksik!");
            return;
        }

        // Calculate the initial offset distance
        aradakiMesafe = transform.position - top.transform.position;
    }

    // Use LateUpdate instead of FixedUpdate if you're dealing with cameras
    void LateUpdate()
    {
        // Check if 'top' is assigned
        if (top == null)
        {
            Debug.LogError("Top referansi eksik!");
            return;
        }

        // Set the camera position to be the same as 'top' with the initial offset
        transform.position = top.transform.position + aradakiMesafe;
    }
}

