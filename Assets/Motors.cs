using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Motors : MonoBehaviour
{
    //public GameObject central/*, bolt*/;
    public Transform pivot;
    public GameObject place_light;
    FixedJoint fj;

    private void Update()
    {
        if (gameObject.CompareTag("Screwed"))
        {
            Destroy(fj);
            gameObject.transform.position = pivot.position;
            //gameObject.transform.parent = GameObject.Find("untitled").transform;
            
            //fj = this.gameObject.AddComponent<FixedJoint>();
            //fj.connectedBody = GameObject.Find("dron2").GetComponent<Rigidbody>();
            //fj.breakForce = 10000;
            //fj.massScale = 20;
            gameObject.transform.parent = GameObject.Find("dron2").transform;
            Destroy(GetComponent<XRGrabInteractable>());
            Destroy(GetComponent<Rigidbody>());
            Destroy(gameObject.GetComponent<Motors>());
        }
    }
    void OnTriggerEnter(Collider myTrigger)
    {
            switch (myTrigger.gameObject.name)
            {
                case "Cube13":
                    Position(myTrigger);
                    break;

                case "Cube14":
                    Position(myTrigger);
                    break;

                case "Cube15":
                    Position(myTrigger);
                    break;

                case "Cube16":
                    Position(myTrigger);
                    break;
            }

    }

    private void Position(Collider myTrigger)
    {
        
        gameObject.transform.position = myTrigger.gameObject.transform.position;
        gameObject.transform.rotation = pivot.transform.rotation;
        if (fj == null)
        {
            fj = this.gameObject.AddComponent<FixedJoint>();
            Destroy(place_light);
            myTrigger.gameObject.tag = "Used";
            //myTrigger.gameObject.tag = "Used";
            //myTrigger.gameObject.AddComponent<fixBolt>().bolt = this.gameObject;
        }

        //myTrigger.gameObject.SetActive(false);
        //gameObject.GetComponent<triggerBolt>().enabled = false;
    }
}
