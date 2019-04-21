using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// USAGE: put on your main camera
// Purpose: demo some camera control technique, like mouse look / following a target.
public class CameraDemo : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // simple mouse look
        
        // 1. get mouse input?
        float horizontalMouseSpeed = Input.GetAxis("Mouse X");
        float verticalMouseSpeed = Input.GetAxis("Mouse Y");
        Debug.Log(horizontalMouseSpeed);

        // 2. use mouse input to rotate camera
        transform.Rotate(0f, horizontalMouseSpeed, 0f);
        Camera.main.transform.Rotate(-verticalMouseSpeed, 0f, 0f);


        // 3. unroll the camera, we need to set it's Z angle to 0f, always.
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0f);

    }
}
