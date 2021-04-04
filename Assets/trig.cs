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

    void OnTriggerEnter(Collider myTrigger)
    {
        

        if (myTrigger.gameObject.name == "Cube")
        {
            central.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            central.AddComponent(typeof(FixedJoint));

            arm.transform.position = pivot.position;
            arm.transform.rotation = pivot.rotation;

            central.GetComponent<FixedJoint>().connectedBody = arm.GetComponent<Rigidbody>();
            //central.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            arm.GetComponentInChildren<trig>().enabled = false;

        }
    }

  


}


