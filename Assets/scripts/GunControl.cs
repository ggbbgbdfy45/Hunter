using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private float sensivity = 2;

    void Update()
    {
        horizontal = Input.GetAxis("Mouse X") * sensivity;
        vertical = Input.GetAxis("Mouse Y") * sensivity;
        transform.Rotate(0, horizontal, vertical);
    }
}
