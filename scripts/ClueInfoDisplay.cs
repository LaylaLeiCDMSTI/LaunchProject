using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueInfoDisplay : MonoBehaviour
{
    public GameObject Clue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisplayClue()
    {
        Debug.Log("Display Clue");
        Clue.SetActive(true);
    }
}
