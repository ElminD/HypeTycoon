﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

	public static int MoneyAmount = 0;
    public Text MoneyText;
    private float nextActionTime = 0.0f;
    public static float period = 1f;
    public static int ClickAmount = 10;
    public static int MoneyPerSec = 1;
	
	// Update is called once per frame
	void Update ()
    {

	    if(Time.time > nextActionTime)
        {
            nextActionTime += period;
            //does shit below here
            MoneyAmount = MoneyAmount + MoneyPerSec;
        }

      

        if (Input.GetMouseButtonDown(0))
        {
            MoneyAmount = MoneyAmount + ClickAmount;
        }

        MoneyText.text = "Money: " + MoneyAmount.ToString();
	}
}
