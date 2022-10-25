using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaMovement : MonoBehaviour
{
    void FixedUpdate()
    {
        Vector3 spawn = new Vector3(0, 7.5f, -25);
        Vector3 move = new Vector3(0, 0, 1);
        transform.Translate(move);
    }
}
