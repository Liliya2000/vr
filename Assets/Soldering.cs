using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldering : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject solder, s1,s2,s3,s4, s5;
    //GameObject soldering;
    double f;
    public Solder Sold;
    steps steps;
    private void Start()
    {
        Sold = GameObject.Find("solder").GetComponent<Solder>();
        steps = GameObject.Find("Text").GetComponent<steps>();
    }
    //private void Update()
    //{
    //    f = Mathf.Sqrt(Mathf.Pow(solder.transform.position.x - transform.position.x, 2) +
    //            Mathf.Pow(solder.transform.position.y - transform.position.y, 2) +
    //            Mathf.Pow(solder.transform.position.z - transform.position.z, 2));
    //}
    void OnTriggerEnter(Collider myTrigger)
    {
        switch (myTrigger.gameObject.name)
        {
            case "Cube1":
                Solder(s1, Sold.Solder1);
                break;

            case "Cube2":
                Solder(s2, Sold.Solder2);
                break;

            case "Cube3":
                Solder(s3, Sold.Solder3);
                break;

            case "Cube4":
                Solder(s4, Sold.Solder4);
                break;

            case "Cube5":
                Solder(s5, Sold.Solder5);
                break;

        }
        
    }
    
    void Solder( GameObject solder, bool sold)
    {
        //if (f < 0.2)
        //{
        //    solder.SetActive(true);
        //    Debug.Log("smth");
        //}
        if (sold)
        {
            solder.SetActive(true);
        }

        

        if(s5.activeInHierarchy)
        {
           //Debug.Log("step 7");
            steps.printText(7);
            Destroy(gameObject.GetComponent<Soldering>());
        } 
        else 
        if (s1.activeInHierarchy && s2.activeInHierarchy && s3.activeInHierarchy && s4.activeInHierarchy)
        {
            //Debug.Log("step 6");
            steps.printText(6);
        }
    }
}
