using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MyLocomotionController : MonoBehaviour
{
    public XRController leftTeleportRay;

    public InputHelpers.Button teleportActivationButton;
    public float activationTherechold = 0.1f;


    // Update is called once per frame
    void Update()
    {
       if (leftTeleportRay)
        {
            leftTeleportRay.gameObject.SetActive(CheckIfActivated(leftTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated, activationTherechold);
        return isActivated;
    }
}
