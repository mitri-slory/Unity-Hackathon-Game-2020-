using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpDetect : MonoBehaviour
{
    public bool CanJump = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    void onCollisionStay(Collision ground)
    {
        CanJump = true;
    }

    void onCollisionExit(Collision ground)
        {
        CanJump = false;

        }
    // Update is called once per frame
    void Update()
        {
        
        }
}
