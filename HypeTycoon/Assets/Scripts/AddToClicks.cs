using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddToClicks : MonoBehaviour
{
    public int Cost;
    public bool UpgradeBought = false;
    public float Boost;
    
    public void ButtonClick()
    {
        if (UpgradeBought == false)
        {
            if (Money.MoneyAmount > Cost)
            {
                Money.MoneyAmount = Money.MoneyAmount - Cost;

                Money.ClickAmount = (int) (Money.ClickAmount + Boost);

                UpgradeBought = true;
                
            }
        }
    }
}
