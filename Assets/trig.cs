using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class trig : MonoBehaviour
{
    public GameObject central, arm;
    public Transform pivot;
    private void Start()
    {
       //if (!arm.GetComponent<FixedJoint>())
       // arm.AddComponent(typeof(FixedJoint));
    }
    void OnTriggerEnter(Collider myTrigger)
    {
       
        if (myTrigger.gameObject.name == "Cube")
        {
            central.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            

            arm.transform.position = pivot.position;
            arm.transform.rotation = pivot.rotation;
            //arm.AddComponent(typeof(FixedJoint));
            if (!arm.GetComponent<FixedJoint>())
            {
                arm.AddComponent<FixedJoint>();
                //arm.GetComponent<FixedJoint>().enableCollision = true;
                arm.GetComponent<FixedJoint>().connectedBody = central.GetComponent<Rigidbody>();
            }
            //if (!central.GetComponent<FixedJoint>())
            //{
            //    central.AddComponent<FixedJoint>().connectedBody = arm.GetComponent<Rigidbody>();
            //}
            //else
            //{
            //    if (central.GetComponent<FixedJoint>().connectedBody != arm.GetComponent<Rigidbody>())
            //        central.AddComponent<FixedJoint>().connectedBody = arm.GetComponent<Rigidbody>();
            //}
            //central.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            //arm.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            arm.GetComponent<trig>().enabled = false;

        }
    }

  


}


