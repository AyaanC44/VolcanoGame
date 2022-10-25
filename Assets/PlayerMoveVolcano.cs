using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVolcano : MonoBehaviour
{

    public Rigidbody rb;

    void FixedUpdate()
    {
        if(Input.GetKey("d"))
        {
            rb.AddForce(20 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-20 * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, 20 * Time.deltaTime);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -20 * Time.deltaTime);
        }
    }
}
