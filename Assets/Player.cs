using System.Collections ;
using System.Collections.Generic ;
using UnityEngine ;
using UnityEngine.SceneManagement ;

public class Player : MonoBehaviour
{
    public GameObject bloodEffect ;

    public int playerHealth = 1000 ;

    public float HealthPercent 
    {
        get {
            return playerHealth/1000 ;
        }
    } 

    public void PlayerDamage(int playerDamage) 
    {
        playerHealth -= playerDamage ;
        if (playerHealth <= 0) {
            Destroy(gameObject,2f) ;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1) ;
        }
        GameObject blood = Instantiate(bloodEffect,transform.position,transform.rotation) ;
        Destroy(blood,0.5f) ;
    }
}
