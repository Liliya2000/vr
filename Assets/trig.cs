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
    public GameObject trigger,Place_light, bolt_light;
    public Transform pivot;
    GameObject[] arms = new GameObject[4];
    //public int destroy = 0;
    FixedJoint fj;
    private steps steps;


    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger==trigger.GetComponent<Collider>())
        {
            gameObject.transform.position = pivot.position;
            gameObject.transform.rotation = pivot.rotation;
            if (fj == null)
            {
                fj = this.gameObject.AddComponent<FixedJoint>();
                // fj.connectedBody = GameObject.Find("untitled").GetComponent<Rigidbody>();
                fj.breakForce = 600;
                Destroy(Place_light);
                gameObject.tag = "arm_done";
                //bolt_light.SetActive(true);
                //fj.massScale = 300;
                //fj.breakForce = 3000000000000;
            }
            if (arms.Length <= 4)
            {
                arms = GameObject.FindGameObjectsWithTag("arm_done");
                if (arms.Length == 4)
                {
                    steps = GameObject.Find("Text").GetComponent<steps>();
                    steps.printText(1);
                    //Destroy(GetComponent<trig>());
                }

            }
        }
    }

}


