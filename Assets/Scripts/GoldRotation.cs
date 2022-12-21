using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldRotation : MonoBehaviour
{
    
    void FixedUpdate()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
}
