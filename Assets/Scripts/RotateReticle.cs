using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateReticle : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(0, 1, 0, Space.World);
    }
}
