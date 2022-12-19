using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    [SerializeField] Transform PlayerTransform;
    [SerializeField] Vector3 CameraOffset;
    
    void LateUpdate()
    {
        transform.position = PlayerTransform.position + CameraOffset;
    }
}
