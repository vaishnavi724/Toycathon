﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class ThirdPersonInput : MonoBehaviour
{

    public FixedJoystick LeftJoystick;
    public FixedButton Button;
    public FixedTouchField TouchField;
    protected ThirdPersonUserControl Control;

    protected float CameraAngle;
   // protected float CameraAngle;
    protected float CameraAngleSpeed = 0.2f;

    // Use this for initialization
    void Start()
    {
        Control = GetComponent<ThirdPersonUserControl>();

    }

    // Update is called once per frame
    void Update()
    {
        Control.m_Jump = Button.Pressed;
        Control.Hinput = LeftJoystick.Horizontal;
        Control.Vinput = LeftJoystick.Vertical;

        CameraAngle += TouchField.TouchDist.x * CameraAngleSpeed;
        //CameraAngle += TouchField.TouchDist.y * CameraAngleSpeed;
        
        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngle,Vector3.up) * new Vector3(0, 4, 6);
        
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 4f - Camera.main.transform.position, Vector3.up);

    }
}
