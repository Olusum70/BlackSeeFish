using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchPlace : MonoBehaviour
{


    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("girdi");
        if (other.tag == "fish" && other.GetComponent<Fish>().isBeingHeld)
        {
            other.GetComponent<Fish>().caught();
        }
    }

}
