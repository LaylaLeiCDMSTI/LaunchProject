using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickCharacter : MonoBehaviour
{
    // Container for hit data
    RaycastHit hitData;
    public GameObject tutorialText;
    // Start is called before the first frame update
    void Start()
    {
        // Creates a Ray from the mouse position
        
    }

    // Update is called once per frame
    void Update()
    {
        //tutorialText = GameObject.Find("Canvas");
        // Creates a Ray from the center of the viewport
        //Ray ray = Camera.main.ViewportPointToRay(new Vector3 (0.5f, 0.5f, 0));
        // Creates a Ray from the mouse position
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    
        // Display Ray
        Debug.DrawRay(ray.origin, ray.direction * 10);
        Vector3 hitPosition = hitData.point;

        if(Physics.Raycast(ray, out RaycastHit hit)){
            Debug.Log(hit.collider.gameObject.name + "was hit!");
            if (Input.GetMouseButtonDown(0)){
                Camera.main.transform.position = hit.collider.gameObject.transform.position;
                Destroy(tutorialText);
            } 
        }

        if (Input.GetButtonDown("Submit")){
            Debug.Log("Start Play");
            SceneManager.LoadScene(1);
        }
    }
}
