using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpThing : MonoBehaviour
{
    // Start is called before the first frame update
    int jump = 0;
    float pow = 0;
    public float scale = 1;
    public Rigidbody rb;
    public MeshCollider Ground;
    bool CanJump = true;
    public float powermax = 3;
    float y = 0f;
    public float hops = .3f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame

    void Update()
    {
        if (rb.transform.position.y != y)
        {
            CanJump = false;
        }
        else
        {
            CanJump = true;
        }
        print(CanJump);
        y = rb.transform.position.y;
        var Dir = Camera.main.transform.forward;
        Dir.y += hops; 
        var distance = Dir.magnitude;
        var Norm_Direction = Dir / distance;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = 1;
        }
        if (jump > 0)
        {
            if (pow < powermax)
            {
                pow += Time.deltaTime;
            }
            GetComponent<Line>().SimulatePath(gameObject, pow * scale * Norm_Direction, rb.mass, rb.drag);

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (CanJump)
            {
                if (pow > powermax)
                {
                    pow = powermax;
                }
                rb.AddForce(pow * scale * Norm_Direction, ForceMode.Impulse);
                pow = 0;
                jump = 0;
            }
        }
}
}
