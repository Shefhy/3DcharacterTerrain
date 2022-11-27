using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daynight : MonoBehaviour
{
    public float speed = 5;
    public float angle = 0;
    public GameObject directLight;

    void ChangeAngle()
    {
        angle += speed;
        Quaternion rot = Quaternion.Euler(angle, 100, 0);
        directLight.transform.rotation = rot;
    }

    void FixedUpdate()
    {
        ChangeAngle();
    }

}
