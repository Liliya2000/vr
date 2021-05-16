using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class trigDop : MonoBehaviour
{
    public GameObject trigger, place_light;
    public Transform pivot;
    FixedJoint fj;
    private steps steps;
    GameObject[] Prop = new GameObject[4];

    private void Start()
    {
        steps = GameObject.Find("Text").GetComponent<steps>();
    }
    void OnTriggerEnter(Collider myTrigger)
    {
        if (myTrigger == trigger.GetComponent<Collider>())
        {

            position();
                
                
                
                //gameObject.transform.localPosition = Vector3.zero;
                //gameObject.transform.localRotation = Quaternion.identity;
                

            if (gameObject.name == "myspeedcontroller")
            {
                steps.printText(4);
            }

            if (gameObject.name == "flight controller")
            {
                steps.printText(8);
            }

            if (gameObject.name == "provoda")
            {
                steps.printText(9);
            }

            if (gameObject.name == "Propeller")
            {
                gameObject.tag = "Prop";
                if (Prop.Length <= 4)
                {
                    Prop = GameObject.FindGameObjectsWithTag("Prop");
                    //Debug.Log();
                    if (Prop.Length == 4)
                    {
                        steps.printText(10);

                    }

                }
            }
            if (gameObject.name == "bottomPlate")
            {
                steps.printText(11);
            }

            //Destroy(GetComponent<trigDop>());
            //Destroy(GetComponent<XRGrabInteractable>());
        }
    }

    void position()
    {
        gameObject.transform.parent = GameObject.Find("dron2").transform;
        Destroy(GetComponent<XRGrabInteractable>());
        Destroy(GetComponent<Rigidbody>());
        Destroy(place_light);
        
        gameObject.transform.position = pivot.position;
        gameObject.transform.rotation = pivot.rotation;
    }
}
