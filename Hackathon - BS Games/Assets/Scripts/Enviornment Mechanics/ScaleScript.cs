using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    
    private Vector3 scaleChange, positionChange;
    private bool rising;

    void Start()
    {

        // Create a plane and move down by 0.5.
        transform.position = new Vector3(0f, -7f, 0f);
        positionChange = new Vector3(0f, 0.05f, 0f);
        rising = false;
    }

    void Update()
    {
        if (rising == true)
        {
            transform.position += positionChange * 1.03f;
        }
    }
    public void StartRising()
    {
        rising = true;
    }
}
