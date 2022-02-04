using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetJoyconData : MonoBehaviour
{
    public GetRightJoycon rightJoycon;
    void Start()
    {

    }

    void Update()
    {
        Debug.Log(rightJoycon.m_pressedButtonR);
        // Debug.Log(rightJoycon.stick);
        // Debug.Log(rightJoycon.accel);
        // Debug.Log(rightJoycon.gyro);
        // Debug.Log(rightJoycon.orientation);

    }
}
