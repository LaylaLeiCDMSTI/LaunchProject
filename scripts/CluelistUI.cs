using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CluelistUI : MonoBehaviour
{
    public InputActionAsset inputActions;
    private InputAction menu;
    private Canvas Cluelist;

    public Clue c;
    // Start is called before the first frame update
    void Start()
    {
        Cluelist = GetComponent<Canvas>();
        menu = inputActions.FindActionMap("XRI LeftHand").FindAction("Menu");
        menu.Enable(); 
        menu.performed += ToggleMenu;

        c.OnFinishClue.AddListener(() =>
        {
            Cluelist.enabled = true;
        });
    }

    private void Update()
    {
        //if(Input.GetKeyDown(KeyCode.M))
        //{
        //    Cluelist.enabled = !Cluelist.enabled;
        //}
    }
    private void OnDestroy( )
    {
        menu.performed -= ToggleMenu;
    }

    public void ToggleMenu(InputAction.CallbackContext context)
    {
        if(!c.isFinish)
        {
            return;
        }
        Cluelist.enabled = !Cluelist.enabled;
    }
}
