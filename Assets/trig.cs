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
    public GameObject trigger;
    public Transform pivot;
    FixedJoint fj;

    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger==trigger.GetComponent<Collider>())
        {
            gameObject.transform.position = pivot.position;
            gameObject.transform.rotation = pivot.rotation;
            if (fj == null)
            {
                fj = this.gameObject.AddComponent<FixedJoint>();
                fj.connectedBody = GameObject.Find("dron2").GetComponent<Rigidbody>();
                //fj.breakForce = 300;
                //fj.breakForce = 3000000000000;
            }
        }
    }

}


