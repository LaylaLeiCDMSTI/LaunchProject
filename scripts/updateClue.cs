using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class updateClue : MonoBehaviour
{
    //public TMP_Text messageText;
    public GameObject notebook;
    private Text clue1;
    public TextMeshProUGUI Cluelist;
    // Start is called before the first frame update


    public int task;
    public int clue;
    void Start()
    {
        //Debug.Log(clue1.text);
       // Cluelist.text += "\n" + notebook.GetComponent<Text>().text;
        //Debug.Log(notebook.GetComponent<Text>().text);
      //  FindObjectOfType<ClueUI>().SetClueEnable(task,clue);
    }

    // Update is called once per frame
    void Update()
    {
        //Cluelist.text += clue1;
    }
    
}
