using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;


public class Clue : MonoBehaviour
{
    public int task;
    public int clue;

    public UnityEvent OnFinishClue;
    public bool isFinish;
    public bool initClue;

    public GameObject clueUI;
    protected virtual void Start()
    {
        ClueFindEvent.Register(ClueFind);
        ClueInit();


        if(initClue)
        {
            ClueStart();
        }
    }

    protected virtual void ClueInit()
    {
        if (task != 0)
            gameObject.SetActive(false);

     
    }

    protected virtual void ClueStart()
    {
        gameObject.SetActive(true);


        GetComponent<XRGrabInteractable>().selectEntered.AddListener((v) =>
        {
            if (!isFinish)
                clueUI.gameObject.SetActive(true);
        });
        clueUI.GetComponentInChildren<Button>(true).onClick.AddListener(() =>
        {
            clueUI.gameObject.SetActive(false);
            OnFinish();
        });
    }
    protected virtual void OnDestroy()
    {
        ClueFindEvent.UnRegister(ClueFind);
    }
    protected virtual void ClueFind(int t,int clue,bool f)
    {
        if(f && t+1==task)
        {
            ClueStart();
        }
    }
    public virtual void OnFinish()
    {
        if (isFinish)
            return;
        isFinish = true;
        OnFinishClue?.Invoke();
        ClueFindEvent.Trigger(task, clue);
    }
}
public struct ClueFindEvent
{
    public static System.Action<int, int, bool> OnClueFind;
    public static void Register(System.Action<int, int, bool> onfind)
    {
        OnClueFind += onfind;
    }

    public static void UnRegister(System.Action<int, int, bool> onfind)
    {
        OnClueFind -= onfind;
    }

    public static void Trigger(int t, int c)
    {
        Clue[] clues = GameObject.FindObjectsOfType<Clue>(true);

        bool allFinish = true;
        foreach (var clue in clues)
        {
            if (clue.task == t)
            {
                if (!clue.isFinish)
                {
                    allFinish = false;
                }
            }
        }
        OnClueFind?.Invoke(t, c, allFinish);
    }
}
