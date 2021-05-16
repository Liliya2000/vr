using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Solder : MonoBehaviour
{
    public bool Solder1 = false, Solder2 = false, Solder3 = false, Solder4 = false, Solder5 = false;
    void OnTriggerEnter(Collider myTrigger)
    {
        switch (myTrigger.gameObject.name)
        {
            case "Cube1":
                Solder1 = true;
                break;

            case "Cube2":
                Solder2 = true;
                break;

            case "Cube3":
                Solder3 = true;
                break;

            case "Cube4":
                Solder4 = true;
                break;

            case "Cube5":
                Solder5 = true;
                break;

        }

    }

    private void OnTriggerExit(Collider myTrigger)
    {
        switch (myTrigger.gameObject.name)
        {
            case "Cube1":
                Solder1 = false;
                break;

            case "Cube2":
                Solder2 = false;
                break;

            case "Cube3":
                Solder3 = false;
                break;

            case "Cube4":
                Solder4 = false;
                break;

            case "Cube5":
                Solder5 = false;
                break;

        }
    }
}
