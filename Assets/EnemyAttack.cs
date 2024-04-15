using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public int AttackDamage = 1 ;

    public void OnCollisionStay2D(Collision2D collision)
    {
        PlayerMovement attack = collision.gameObject.GetComponent<PlayerMovement>() ;
        if (attack) {
            Player PlayerHealth = collision.gameObject.GetComponent<Player>() ;
            PlayerHealth.PlayerDamage(AttackDamage) ;
        }
    }
}
