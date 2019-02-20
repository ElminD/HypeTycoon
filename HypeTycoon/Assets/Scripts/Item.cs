using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public int Cost;
    public bool itemBought = false;
    public int Boost;
    public SpriteRenderer spriteRenderer;

    
    
    public void ButtonClick()
    {
        if (itemBought == false)
        {
            if (Money.MoneyAmount > Cost)
            {
                Money.MoneyAmount = Money.MoneyAmount - Cost;


                Money.MoneyPerSec = Money.MoneyPerSec + Boost;

                itemBought = true;
                
                this.spriteRenderer.enabled = true;
            }
        }
    } 
}
