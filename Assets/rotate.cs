using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(0, 10, 0));
    }
}
