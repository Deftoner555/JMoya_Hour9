using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerExercise : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the cube");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the cube");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the cube");
    }
}
