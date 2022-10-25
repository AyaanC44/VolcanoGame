using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveVolcano : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 tranD = new Vector3(1.5f, 0, 0);
        Vector3 tranA = new Vector3(-1.5f, 0, 0);
        Vector3 tranW = new Vector3(0, 0, 1.5f);
        Vector3 tranS = new Vector3(0, 0, -1.5f);
        
        if(Input.GetKey("d"))
        {
            transform.Translate(tranD);
        }

        if(Input.GetKey("a"))
        {
            transform.Translate(tranA);
        }

        if(Input.GetKey("w"))
        {
            transform.Translate(tranW);
        }

        if(Input.GetKey("s"))
        {
            transform.Translate(tranS);
        }
    }
}
