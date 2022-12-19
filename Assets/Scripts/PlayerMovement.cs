using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody pRigid;
    void Start()
    {
        pRigid = FindObjectOfType<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        

        if (Input.GetKey("w"))
        {
            pRigid.AddForce(0, 0, 1000 * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            pRigid.AddForce(-500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d"))
        {
            pRigid.AddForce(500 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s"))
        {
            pRigid.AddForce(0, 0, -1000 * Time.deltaTime);
        }
    }
}
