using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    private float speed = .05f;

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the cube");
    }

    void Update()
    {
        float mY = Input.GetAxis("Vertical") * speed;
        float mX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(mX, mY, 0);
    }
}
