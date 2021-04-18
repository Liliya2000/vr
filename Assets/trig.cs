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
    public Transform pivot;
    FixedJoint fj;

    void OnTriggerEnter(Collider myTrigger)
    {
       
        if (myTrigger.gameObject.name == "Cube")
        {
            gameObject.transform.position = pivot.position;
            gameObject.transform.rotation = pivot.rotation;
            if (fj == null)
            {
                fj = this.gameObject.AddComponent<FixedJoint>();
                fj.breakForce = 300;
            }
        }
    }

}


