using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVolcano : MonoBehaviour
{

    public RigidBody rb;

    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.addForce(20 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.addForce(-20 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("w"))
        {
            rb.addForce(0, 0, 20 * Time.deltaTime);
        }

        if(Input.GetKey("s"))
        {
            rb.addForce(0, 0, -20 * Time.deltaTime);
        }
    }
}
