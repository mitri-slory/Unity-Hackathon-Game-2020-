using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int powermax = 20;
    int jump = 0;
    float pow = 0;
    public float scale = 1;
    public Rigidbody rb;
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    Vector3 velocity;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;
    public float jumpHeight = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        if (isGrounded)
        {
            velocity.x = 0;
            velocity.z = 0;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        var Dir = Camera.main.transform.forward;
        var distance = Dir.magnitude;
        var Norm_Direction = Dir / distance;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = 1;
        }
        if (jump > 0)
        {
            pow += Time.deltaTime;
        }
        

        if (Input.GetKeyUp(KeyCode.Space))
        {
            if (isGrounded)
            {
                if (pow > powermax)
                {
                    pow = powermax;
                }
                velocity = pow * scale * Norm_Direction;
                pow = 0;
                jump = 0;
            }
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity* Time.deltaTime);
    }
}
