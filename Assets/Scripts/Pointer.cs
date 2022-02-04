using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointer : MonoBehaviour
{
    public GetRightJoycon rightJoycon;
    void Start()
    {

    }


    void Update()
    {

        var pos = this.transform.position;
        var gyro = rightJoycon.gyro / 10;
        if (Mathf.Abs(gyro.z) < 0.01f) gyro.z = 0;
        if (Mathf.Abs(gyro.y) < 0.01f) gyro.y = 0;

        pos.x += gyro.z;
        pos.y += gyro.y;

        this.transform.position = pos;


    }
}
