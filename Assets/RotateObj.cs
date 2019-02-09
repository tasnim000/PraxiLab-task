using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObj : MonoBehaviour
{
    float rotSpeed = 20;
    private void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

       gameObject.transform.RotateAround(Vector3.up, -rotX);
       gameObject.transform.RotateAround(Vector3.right, rotY);
    }

    
}
