using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class endDrag : MonoBehaviour
{
    bool endDrag_ = false;
    
    private void Start()
    {
        //GameObject dragg = GetComponent<drag>();
    }
    public void OnTriggerEnter(Collider other)
    {
        drag ds = other.GetComponent<drag>();
        if (ds.Drag)
        {
            endDrag_ = false;
            Debug.Log("drag");
        }
        else
        {
            endDrag_ = true;
            ds.Drag = false;
            Debug.Log("drop");
        }
    }
}
