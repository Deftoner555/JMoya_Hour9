using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    private float speed = .05f;

    void Update()
    {
        float mY = Input.GetAxis("Vertical") * speed;
        float mX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(mX, mY, 0);
    }
}
