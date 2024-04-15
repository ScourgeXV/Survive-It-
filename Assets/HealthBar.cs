using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public UnityEngine.UI.Image healthBar ;

    public void UpdateHealthBar(Player player) 
    {
        healthBar.fillAmount = player.HealthPercent ;
    }
}
