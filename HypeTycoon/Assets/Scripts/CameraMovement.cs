using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera CameraMain;
    private int speed = 10;
    public double x = 12.86;

    
    public void ButtonClickRight()
    {

        CameraMain.transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
    }

    public void ButtonClickLeft()
    {
        if (CameraMain.transform.position.x != x)
        {
            CameraMain.transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
    }
}
