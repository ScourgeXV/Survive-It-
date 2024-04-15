using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class Enemy : MonoBehaviour
{
    public int health = 100 ;
    public int enemies = 24 ;
    
    public GameObject deathEffect ; 

    public void TakeDamage(int damage) 
    {      
        health -= damage ;
        if (health <= 0) {
            GameObject death = Instantiate(deathEffect,transform.position,Quaternion.identity) ;
            Destroy(death,1f) ;
            Destroy(gameObject) ;
            enemies -= 1 ;
            if (enemies == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
            }   
        }
    }

    public void Update() 
    {
        if (enemies == 0) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
            }
    }
}
