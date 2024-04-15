using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAwareness : MonoBehaviour
{
    public Transform player ;

    public bool Aware {get ; private set ;} 
    public Vector2 PlayerDir {get ; private set ;} 
    public float awareDist ;

    // Update is called once per frame
    void Update()
    {
        Vector2 enemy2player = player.position - transform.position ;
        PlayerDir = enemy2player.normalized ;

        if (enemy2player.magnitude <= awareDist) {
            Aware = true ;
        }
        else {
            Aware = false ;
        }
    }
}
