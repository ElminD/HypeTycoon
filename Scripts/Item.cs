using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour {

    public int Cost;
    public bool itemBought = false;
    public int Boost;

    
    
    public void ButtonClick()
    {
        if (Money.MoneyAmount > Cost)
        {
            Money.MoneyAmount = Money.MoneyAmount - Cost;

            itemBought = true;

            if (itemBought = true)
            {
                Money.MoneyPerSec = Money.MoneyPerSec + Boost;
            }

        }

        
    }

    

    
}
