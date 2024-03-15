using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCam : MonoBehaviour
{

    private Transform cam;
    private void Start()
    {
        cam = Camera.main.transform;
        



    }

    private void Update()
    {

        Vector3 f = cam.forward;
        f.y = 0;

        transform.forward = f;
    }
}
