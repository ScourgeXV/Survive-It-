using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject impactEffect ;
    public int damage = 20 ;

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>() ;
        if (enemy) {
            enemy.TakeDamage(damage) ;
        }

        Destroy(gameObject) ;
        
        GameObject impact = Instantiate(impactEffect,transform.position,transform.rotation) ;
        Destroy(impact,0.2f) ;
    }
}