using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GetRightJoycon : MonoBehaviour
{

    private static readonly Joycon.Button[] m_buttons =
        Enum.GetValues(typeof(Joycon.Button)) as Joycon.Button[];

    private List<Joycon> m_joycons;

    private Joycon m_joyconR;
    public Joycon.Button? m_pressedButtonR;

    public float[] stick;
    public Vector3 gyro;
    public Vector3 accel;
    public Quaternion orientation;

    void Start()
    {
        SetControllers();
    }


    void Update()
    {
        m_pressedButtonR = null;
        if (m_joycons == null || m_joycons.Count <= 0) return;
        SetControllers();

        foreach (var button in m_buttons)
        {
            if (m_joyconR.GetButton(button))
            {
                m_pressedButtonR = button;
            }
        }

        foreach (var joycon in m_joycons)
        {
            if (!joycon.isLeft)
            {
                stick = joycon.GetStick();
                gyro = joycon.GetGyro();
                accel = joycon.GetAccel();
                orientation = joycon.GetVector();
            }

        }


    }

    private void SetControllers()
    {
        m_joycons = JoyconManager.Instance.j;
        if (m_joycons == null || m_joycons.Count <= 0) return;
        m_joyconR = m_joycons.Find(c => !c.isLeft);
    }
}
