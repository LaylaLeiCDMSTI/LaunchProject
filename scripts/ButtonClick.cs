using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    public Button newButton;
    public GameObject _actionObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void disableClueCanva()
    {
        Debug.Log("Clicked");
        _actionObject.SetActive(false);
    }
}
