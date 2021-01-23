using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OpacityTest : MonoBehaviour
{
    public GameObject Platform;
    public GameObject User;

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, Platform.transform.position);
        float Opacity = 1 - 2 / (distance);

        Color color = this.GetComponent<MeshRenderer>().material.color;
        color.a = Opacity;
        this.GetComponent<MeshRenderer>().material.color = color;
    }
}
