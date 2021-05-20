using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using OVR;
using OVRTouchSample;

public class UseScreewDriver : MonoBehaviour
{
    //public GameObject central;
    GameObject /*bolt,*/ dron;
    public GameObject step2, place_light;
    public Transform pivot;
    int destroy = 0;
    private steps steps;
    bool press = false;
    public bool test = false;


    //private XRController controller;

    //private void Start()
    //{
    //    controller = GetComponent<XRController>();
    //}

    //[System.Obsolete]

    private void Update()
    {
        if (test)
        {
           //dron = GameObject.Find("dron2");
            steps = GameObject.Find("Text").GetComponent<steps>();
            steps.printText(12);
            //Destroy(dron.GetComponent<XRGrabInteractable>());
            //dron.AddComponent<XRGrabInteractable>();
            GameObject.Find("LeftHand Controller").GetComponent<testActionController>().enabled = true;
            //dron.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //dron.GetComponent<CharacterController>().enabled = true;
            test = false;
        }
    }

    void OnTriggerEnter(Collider myTrigger)
    {

        //List<InputDevice> rightHand = new List<InputDevice>();
        //InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHand);
        //InputDevices.GetDevicesWithRole(InputDeviceRole.RightHanded, rightHand);
        //bool isPressed;

        //if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position))
        //    Debug.Log("trigger");


        //OVRInput.Update();
        //if (XRSettings.isDeviceActive)
        //{
        //    if (OVRInput.Get(OVRInput.Button.One))
        //    {
        //        SwitchBox(myTrigger);
        //    }
        //}
        //else
        //Debug.Log("pressed");
            SwitchBox(myTrigger);

    }

    public void pressed()
    {
        press = true;
        Debug.Log(press);
    }

    public void not_pressed()
    {
        press = false;
        Debug.Log(press);
    } 

    private void SwitchBox(Collider myTrigger)
    {
        if (press)
        {
            if (myTrigger.gameObject.tag == "Used")
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

                    case "CubeB9":
                        Position(myTrigger);
                        break;

                    case "CubeB10":
                        Position(myTrigger);
                        break;

                    case "CubeB11":
                        Position(myTrigger);
                        break;

                    case "CubeB12":
                        Position(myTrigger);
                        break;
                }
            }
        }
    }
    private void Position(Collider myTrigger)
    {
        myTrigger.gameObject.GetComponent<fixBolt>().bolt.tag = "Screwed";
        myTrigger.gameObject.SetActive(false);
        Destroy(myTrigger.gameObject); destroy++;
        //Debug.Log(destroy);

        if (destroy == 8)
        {
            //Instantiate(step2, untitled.transform, true );
            //step2.transform.position = untitled.transform.position;
            //step2.transform.localScale()
            //Snap(GameObject.Find("quadArm1"));
            //Snap(GameObject.Find("quadArm2"));
            //Snap(GameObject.Find("quadArm3"));
            //Snap(GameObject.Find("quadArm4"));

            //Rigidbody rigidbody= untitled.GetComponent<Rigidbody>();
            //rigidbody.constraints = RigidbodyConstraints.None;
            place_light.SetActive(true);
            GameObject.Find("rama").tag = "Delete";
            steps = GameObject.Find("Text").GetComponent<steps>();
            steps.printText(3);
            step2.SetActive(true);
        }
        if (destroy == 12)
        {
            dron = GameObject.Find("Step2");
            Destroy(dron);
            steps = GameObject.Find("Text").GetComponent<steps>();
            //GameObject.Find("LeftHand Controller").GetComponent<testActionController>().enabled = true;
            steps.printText(12);
            //Destroy(dron.GetComponent<XRGrabInteractable>());
            //dron.AddComponent<XRGrabInteractable>();
            //dron.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }

    }

    //private void Snap(GameObject gameObject)
    //{
        
    //    //gameObject.transform.parent = untitled.transform;
    //    Destroy(gameObject.GetComponent<trig>());
    //    Destroy(gameObject.GetComponent<XRGrabInteractable>());
    //    //gameObject.GetComponent<FixedJoint>().connectedBody = untitled.GetComponent<Rigidbody>();
    //   // gameObject.GetComponent<FixedJoint>().breakForce = 10000000000000;
    //}
}
//if (Input.GetKey(KeyCode.E)) ;