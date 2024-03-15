using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

 
public class ClueUI : MonoBehaviour
{
    public Color color_taskEnable;
    public Color color_disable;

    public Color color_clueEnable;
    public GameObject[] img_tasks;

    public GameObject[] img_clues;


    private void OnEnable()
    {
        ClueFindEvent.Register(ClueFind);
    }
    private void ClueFind(int task,int clue, bool f)
    {
      
        img_tasks[task].transform.GetChild(1).GetChild(clue).GetComponent<Image>().color = color_clueEnable;
        img_tasks[task].transform.GetChild(1).GetChild(clue).GetComponentInChildren<TextMeshProUGUI>().text = "CLUE " + (clue + 1).ToString();
        img_tasks[task].transform.GetChild(1).GetChild(clue).GetComponent<Button>().onClick.AddListener(() =>
        {
            string name = string.Format("{0}_{1}", task, clue);
            Debug.Log(name);
            foreach (var v in img_clues)
            {
                
                if (v.name == name)
                {
                    v.gameObject.SetActive(true);
      
                    break;
                }
            }
        });


        if (f)
        {
            if(task+1 < img_tasks.Length)
            {

                if(task+1 == 4)
                {
                    img_tasks[task + 1].transform.GetChild(0).GetComponent<Image>().color = color_taskEnable;
                    img_tasks[task + 1].transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = "Quiz " + (task + 2).ToString();
                }
                else
                {
                    img_tasks[task + 1].transform.GetChild(0).GetComponent<Image>().color = color_taskEnable;
                    img_tasks[task + 1].transform.GetChild(0).GetComponentInChildren<TextMeshProUGUI>().text = "Task " + (task + 2).ToString();
                }
            }
         
        }
    }
    private void OnDisable()
    {
        ClueFindEvent.UnRegister(ClueFind);
    }
    public void SetClueEnable(int task,int clue)
    {
         

  
    }
}
