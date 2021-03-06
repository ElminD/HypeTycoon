﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUpCamera : MonoBehaviour
{
    public Camera CameraMain;
    private int speed = 10;
    public double x = 12.86;
    private bool holding;
    
    private void FixedUpdate()
    {
        if (holding == true)
        {
            CameraMain.transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }
    }
    
    public void ButtonHeldYes()
    {

        holding = false;
    }

    public void ButtonHeldNo()
    {

        holding = true;
    }
}
