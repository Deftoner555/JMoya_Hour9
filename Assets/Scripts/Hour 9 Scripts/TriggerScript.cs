using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(gameObject.name + " was entered");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Sphere is still in " + gameObject.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Sphere has exited " + gameObject.name);
    }
}
