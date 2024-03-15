using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class PlayerMoveEnabler : MonoBehaviour
{
    public void SetMoveEnable(bool e)
    {
        GetComponent<DynamicMoveProvider>().enabled = e;
    }
}
