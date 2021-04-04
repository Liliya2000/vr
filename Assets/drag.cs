using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class drag : MonoBehaviour
{
    public bool Drag = false;
    public void OnTriggerEnter(Collider other)
    {
        //endDrag ed = other.GetComponent<endDrag>();
        //if (ed.endDrag_)
        Drag = true;
    }
  
}
