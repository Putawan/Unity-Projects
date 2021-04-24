using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiltboard : MonoBehaviour
{

    public int speed = 10;
    public Vector3 currentRotation;

    // Update is called once per frame
    void Update()
    {
        currentRotation = GetComponent<Transform>().eulerAngles;

        if ((Input.GetAxis("Horizontal") > 0.2) && (currentRotation.z >= 349 || currentRotation.z <= 11))
        {
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }

        if ((Input.GetAxis("Horizontal") < -0.2) && (currentRotation.z <= 10 || currentRotation.z >= 348))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
        }

        if ((Input.GetAxis("Vertical") > 0.2) && (currentRotation.x <= 10 || currentRotation.x >= 348))
        {
            transform.Rotate(speed * Time.deltaTime, 0, 0);
        }

        if ((Input.GetAxis("Vertical") < -0.2) && (currentRotation.x >= 349 || currentRotation.x <= 11))
        {
            transform.Rotate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
