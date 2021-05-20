using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 10, 0));
    }

    //if (timer <= 1)
    //    {
    //        // Time.deltaTime*100 will make sure we are moving at a constant speed of 100 per second
    //        transform.Rotate(0f, 0f, Time.deltaTime* 100);
    //        // Increment the timer so we know when to stop
    //        timer += Time.deltaTime;
    //    }
}
