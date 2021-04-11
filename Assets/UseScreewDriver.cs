using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class UseScreewDriver : MonoBehaviour
{
    public GameObject central;
    GameObject bolt;
    public Transform pivot;

    [System.Obsolete]
    void OnTriggerEnter(Collider myTrigger)
    {

        List<InputDevice> rightHand = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHand);
        InputDevices.GetDevicesWithRole(InputDeviceRole.RightHanded, rightHand);
        bool isPressed;
        
        if (XRSettings.isDeviceActive)
        {
            InputHelpers.IsPressed(rightHand[0], InputHelpers.Button.TriggerPressed, out isPressed);

            if (isPressed)
                SwitchBox(myTrigger);
        }
        else SwitchBox(myTrigger);

    }

    private void SwitchBox(Collider myTrigger)
    {
        switch (myTrigger.gameObject.name)
        {
            case "CubeB1":
                Position(myTrigger);
                break;

            case "CubeB2":
                Position(myTrigger);
                break;

            case "CubeB3":
                Position(myTrigger);
                
                break;

            case "CubeB4":
                Position(myTrigger);
                
                break;

            case "CubeB5":
                Position(myTrigger);
                
                break;

            case "CubeB6":
                Position(myTrigger);
                
                break;

            case "CubeB7":
                Position(myTrigger);
                
                break;

            case "CubeB8":
                Position(myTrigger);
                
                break;
        }
    }
    private void Position(Collider myTrigger)
    {
        bolt = myTrigger.gameObject.GetComponent<screw>().Screw;
        Vector3 position = new Vector3(bolt.transform.position.x, bolt.transform.position.y, pivot.position.z);
        bolt.transform.position = position;
        myTrigger.gameObject.SetActive(false);
        //gameObject.transform.position = myTrigger.gameObject.transform.position;
        //gameObject.transform.rotation = pivot.transform.rotation;
        ////if (!central.GetComponent<FixedJoint>())
        //central.AddComponent<FixedJoint>().connectedBody = gameObject.GetComponent<Rigidbody>();
        //gameObject.GetComponent<triggerBolt>().enabled = false;
        //myTrigger.gameObject.SetActive(false);
    }
}
