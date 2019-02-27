using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour {

    public int Cost;
    public bool UpgradeBought = false;
    public int Boost;
    public SpriteRenderer spriteRenderer;

    
    
    public void ButtonClick()
    {
        if (UpgradeBought == false)
        {
            if (Money.MoneyAmount > Cost)
            {
                Money.MoneyAmount = Money.MoneyAmount - Cost;


                Money.MoneyPerSec = Money.MoneyPerSec + Boost;

                UpgradeBought = true;
                
                this.spriteRenderer.enabled = true;
            }
        }
    } 
}
