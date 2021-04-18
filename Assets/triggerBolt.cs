using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBolt : MonoBehaviour
{
    public GameObject central/*, bolt*/;
    public Transform pivot;
    FixedJoint fj;

    private void Update()
    {
        if (gameObject.CompareTag("Screwed"))
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 0.809f, gameObject.transform.position.z);
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        //Debug.Log(myTrigger.gameObject.name);
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
