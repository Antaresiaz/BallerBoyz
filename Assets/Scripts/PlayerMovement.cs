using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody pRigid;
    [SerializeField] float playerSpeed;
    [SerializeField] float turnSpeed;
    void Start()
    {
        pRigid = FindObjectOfType<Rigidbody>();
    }

    
    void FixedUpdate()
    {
        

        if (Input.GetKey("w"))
        {
            pRigid.AddForce(0, 0, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            pRigid.AddForce(-turnSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            pRigid.AddForce(turnSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("s"))
        {
            pRigid.AddForce(0, 0, -playerSpeed * Time.deltaTime);
        }
    }
}
