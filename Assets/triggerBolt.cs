using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class triggerBolt : MonoBehaviour
{
    public GameObject central/*, bolt*/;
    public Transform pivot;
    FixedJoint fj;

    private void Update()
    {
        if (gameObject.CompareTag("Screwed"))
        {
            Destroy(fj);
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.021f, gameObject.transform.position.z); ;
            //gameObject.transform.parent = GameObject.Find("untitled").transform;
            Destroy(gameObject.GetComponent<XRGrabInteractable>());
            gameObject.AddComponent<FixedJoint>();
            gameObject.transform.parent = GameObject.Find("rama").transform;
            if (GameObject.Find("rama").CompareTag("Delete"))
            {
                Destroy(GameObject.Find("rama"));
            }
            Destroy(gameObject.GetComponent<triggerBolt>());
        }
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        
        if (myTrigger.gameObject.tag != "Used")
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

        gameObject.transform.position = myTrigger.gameObject.transform.position;
        gameObject.transform.rotation = pivot.transform.rotation;
        if (fj == null)
        {
            fj = this.gameObject.AddComponent<FixedJoint>();

            myTrigger.gameObject.tag = "Used";
            myTrigger.gameObject.AddComponent<fixBolt>().bolt = this.gameObject;
        }
            
        //myTrigger.gameObject.SetActive(false);
        //gameObject.GetComponent<triggerBolt>().enabled = false;
    }
}
