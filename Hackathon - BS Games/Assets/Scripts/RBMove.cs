using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBMove : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody rb;
    bool CanJump = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var Dir = Camera.main.transform.forward;
        var distance = Dir.magnitude;
        var Norm_Direction = Dir / distance;
        float x = Norm_Direction.x / Mathf.Sqrt(Norm_Direction.x * Norm_Direction.x + Norm_Direction.z * Norm_Direction.z);
        float z = Norm_Direction.z / Mathf.Sqrt(Norm_Direction.x * Norm_Direction.x + Norm_Direction.z * Norm_Direction.z);
        //rb.velocity = {x, rb.velocity.y,z};
    }
}
