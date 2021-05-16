using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class trig_motors : MonoBehaviour
{
    //public GameObject central;
    GameObject motors;
    public GameObject untitled, step2;
    public Transform pivot;
    GameObject[] motorsScrew;
    private steps steps;

    //[System.Obsolete]

    void OnTriggerEnter(Collider myTrigger)
    {

        OVRInput.Update();
        if (XRSettings.isDeviceActive)
        {
            if (OVRInput.Get(OVRInput.Button.One))
            {
                SwitchBox(myTrigger);
            }
        }
        else
            SwitchBox(myTrigger);

    }

    private void SwitchBox(Collider myTrigger)
    {
        if (myTrigger.gameObject.CompareTag("Used"))
        {
            switch (myTrigger.gameObject.name)
            {

                case "Cube13":
                    motors = GameObject.Find("motor1");
                    Position(myTrigger);

                    break;

                case "Cube14":
                    motors = GameObject.Find("motor2");
                    Position(myTrigger);

                    break;

                case "Cube15":
                    motors = GameObject.Find("motor3");
                    Position(myTrigger);

                    break;

                case "Cube16":
                    motors = GameObject.Find("motor4");
                    Position(myTrigger);

                    break;
            }
        }
    }
    FixedJoint fj;
    private void Position(Collider myTrigger)
    {
        //motors.transform.position = pivot.transform.position;
        //motors.transform.rotation = pivot.transform.rotation;
        //if (fj == null)
        //{
        //    fj = motors.AddComponent<FixedJoint>();
        //    fj.connectedBody = GameObject.Find("dron2").GetComponent<Rigidbody>();
        //    fj.breakForce = 10000;
        //    fj.massScale = 20;

        //    //fj.breakForce = 3000000000000;
        //}
        //Destroy(motors.GetComponent<trigDop>());
        //Destroy(motors.GetComponent<XRGrabInteractable>());
        motors.tag = "Screwed";
        motorsScrew = GameObject.FindGameObjectsWithTag("Screwed");
        if (motorsScrew.Length==4)
        {
            steps = GameObject.Find("Text").GetComponent<steps>();
            steps.printText(5);
        }

    }

}
