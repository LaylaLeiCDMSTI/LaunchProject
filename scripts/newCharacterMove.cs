using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
//using UnityEngine.XR.Interaction.Toolkit;
//using UnityEngine.InputSystem;

public class newCharacterMove : MonoBehaviour
{
    //private Vector2 movementInput;
    // Start is called before the first frame update
    public float moveSpeed = 3.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UnityEngine.XR.InputDevice joytickR =  UnityEngine.XR.InputDevices.GetDeviceAtXRNode(XRNode.RightHand);

        Vector2 primary2DAxis;
        if (joytickR.TryGetFeatureValue(UnityEngine.XR.CommonUsages.primary2DAxis, out primary2DAxis))
        {
            MoveCharacter(primary2DAxis);
        }
        
    }

    void MoveCharacter(Vector2 input) {
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 MoveDirection = new Vector3(input.x, 0, input.y);
        MoveDirection = transform.TransformDirection(MoveDirection);
        controller.Move(MoveDirection * Time.deltaTime * moveSpeed);
    }
}
 