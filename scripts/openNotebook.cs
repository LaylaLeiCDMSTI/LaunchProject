using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openNotebook : MonoBehaviour
{
    GameObject notebook1;
    
    // Applies an upwards force to all rigidbodies that enter the trigger.
    void Start()
    {
        notebook1 = GameObject.Find ("notebook1");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Hand" && Input.GetMouseButton(0))
            notebook1.transform.position = other.transform.position;
        else
            notebook1.transform.position = notebook1.transform.position;
    }

}
