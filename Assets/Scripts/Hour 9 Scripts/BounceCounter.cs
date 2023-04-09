using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceCounter : MonoBehaviour
{
    int Bcount = 0;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Bcount++;
            Debug.Log("Bounce count: " + Bcount);
        }
    }
}
