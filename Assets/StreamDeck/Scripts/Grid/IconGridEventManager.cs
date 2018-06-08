using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class IconGridEventManager : MonoBehaviour, IVirtualButtonEventHandler {

    #region PRIVATE_MEMBERS
    VirtualButtonBehaviour[] virtualButtonBehaviours;
    #endregion //PRIVATE_MEMBERS

    #region MONOBEHAVIOUR_METHODS
    void Start() {
        // Register with the virtual buttons TrackableBehaviour
        virtualButtonBehaviours = GetComponentsInChildren<VirtualButtonBehaviour>();

        for (int i = 0; i < virtualButtonBehaviours.Length; ++i) {
            virtualButtonBehaviours[i].RegisterEventHandler(this);
        }

        GridManager.instance.SwapIconCollection(0);
    }
    #endregion // MONOBEHAVIOUR_METHODS

    #region PUBLIC_METHODS
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        Debug.Log("OnButtonPressed: " + vb.VirtualButtonName);
        IActionIcon actionIcon = vb.GetComponent<IActionIcon>();
        if (actionIcon != null) {
            actionIcon.ExecuteAction();
        }
    }

    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("OnButtonReleased: " + vb.VirtualButtonName);
    }
    #endregion //PUBLIC_METHODS
}
