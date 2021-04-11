using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBolt : MonoBehaviour
{
    public GameObject central/*, bolt*/;
    public Transform pivot;
    void OnTriggerEnter(Collider myTrigger)
    {
        //Debug.Log(myTrigger.gameObject.name);
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
        }

    }

    private void Position(Collider myTrigger)
    {

        //gameObject.transform.position = myTrigger.gameObject.transform.position;
        //gameObject.transform.rotation = pivot.transform.rotation;
        //if (!GetComponent<FixedJoint>())
        //    gameObject.AddComponent<FixedJoint>().connectedBody = central.GetComponent<Rigidbody>();
        //gameObject.GetComponent<triggerBolt>().enabled = false;
        //myTrigger.gameObject.SetActive(false);

        gameObject.transform.position = myTrigger.gameObject.transform.position;
        gameObject.transform.rotation = pivot.transform.rotation;
        //if (!central.GetComponent<FixedJoint>())
            central.AddComponent<FixedJoint>().connectedBody = gameObject.GetComponent<Rigidbody>();
        myTrigger.gameObject.AddComponent<screw>().Screw = gameObject;
        gameObject.GetComponent<triggerBolt>().enabled = false;
        //myTrigger.gameObject.SetActive(false);
    }
}
