using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class UseScreewDriver : MonoBehaviour
{
    //public GameObject central;
    GameObject bolt;
    public GameObject untitled, step2;
    public Transform pivot;
    int destroy = 0;
    struct BoxIsTrigger
    {
        Collider MyTrigger;
        //public string getTag( Collider MyTrigger)
        //{

        //}

    }
    
    private void Start()
    {
        //Instantiate(step2, untitled.transform, false);


        //untitled = GameObject.Find("untitled");
        //GameObject untitle = GameObject.Find("untitled");
        //GameObject.Find("quadArm1").transform.parent = untitle.transform;

        //MeshFilter[] meshFilters = untitle.GetComponentsInChildren<MeshFilter>();
        //CombineInstance[] combine = new CombineInstance[meshFilters.Length];

        //int i = 0;
        //while (i < meshFilters.Length)
        //{
        //    combine[i].mesh = meshFilters[i].sharedMesh;
        //    //combine[i].transform = meshFilters[i].transform.localToWorldMatrix;
        //    meshFilters[i].gameObject.SetActive(false);
        //    i++;
        //}
        //untitle.transform.GetComponent<MeshFilter>().mesh = new Mesh();
        //untitle.transform.GetComponent<MeshFilter>().mesh.CombineMeshes(combine);
        ////untitle.transform.gameObject.SetActive(true);
    }
    
    //[System.Obsolete]
    void OnTriggerEnter(Collider myTrigger)
    {
        
        //List<InputDevice> rightHand = new List<InputDevice>();
        //InputDevices.GetDevicesAtXRNode(XRNode.RightHand, rightHand);
        //InputDevices.GetDevicesWithRole(InputDeviceRole.RightHanded, rightHand);
        //bool isPressed;

        //if (XRSettings.isDeviceActive)
        //{
        //    InputHelpers.IsPressed(rightHand[0], InputHelpers.Button.TriggerPressed, out isPressed);

        //    if (isPressed)
        //        SwitchBox(myTrigger);
        //}
        //else
        SwitchBox(myTrigger);

    }

    private void SwitchBox(Collider myTrigger)
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
    private void Position(Collider myTrigger)
    {
        myTrigger.gameObject.GetComponent<fixBolt>().bolt.tag = "Screwed";
        myTrigger.gameObject.SetActive(false);
        Destroy(myTrigger.gameObject); destroy ++;
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
            GameObject.Find("rama").tag = "Delete";
            step2.SetActive(true);
        }
        
    }

    private void Snap(GameObject gameObject)
    {
        
        //gameObject.transform.parent = untitled.transform;
        Destroy(gameObject.GetComponent<trig>());
        Destroy(gameObject.GetComponent<XRGrabInteractable>());
        //gameObject.GetComponent<FixedJoint>().connectedBody = untitled.GetComponent<Rigidbody>();
       // gameObject.GetComponent<FixedJoint>().breakForce = 10000000000000;
    }
}
//if (Input.GetKey(KeyCode.E)) ;