using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openClassList : MonoBehaviour
{
    GameObject classlist;
    
    // Applies an upwards force to all rigidbodies that enter the trigger.
    void Start()
    {
        classlist = GameObject.Find ("classlist");
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Hand" && Input.GetMouseButton(0))
            classlist.transform.position = other.transform.position;
        else
            classlist.transform.position = classlist.transform.position;
    }
}
