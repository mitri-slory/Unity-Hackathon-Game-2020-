using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fooScript : MonoBehaviour
{
    public GameObject other;
    public GameObject waldo;
    public float MOVE_SPEED = 2.0f;

    // Start is called before the first frame update

    void Start()
    {
        waldo = GameObject.Find("waldo");
        waldo.GetComponent<Renderer>().material.color = Color.blue;
        other.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");

        if (horizontalAxis < 0)
        {
            Debug.Log("Left");
            transform.position = new Vector3(transform.position.x + MOVE_SPEED * Time.deltaTime, transform.position.y, transform.position.z);

        }
        else if (horizontalAxis > 0)
        {
            Debug.Log("Right");
            transform.position = new Vector3(transform.position.x - MOVE_SPEED * Time.deltaTime, transform.position.y, transform.position.z);
        }
        if (verticalAxis < 0)
        {
            Debug.Log("Down");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + MOVE_SPEED * Time.deltaTime);
        }
        else if (verticalAxis > 0)
        {
            Debug.Log("Up");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - MOVE_SPEED * Time.deltaTime);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Firing");
        }
    }
}