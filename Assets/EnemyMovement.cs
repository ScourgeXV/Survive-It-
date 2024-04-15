using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Rigidbody2D rb ;
    public PlayerAwareness playerAwareness ;

    public float speed ;
    public float rotSpeed ;
    public Vector2 targetDir ;

    // Update is called once per frame
    void FixedUpdate()
    {
        UpdateDir() ;
        Rotate2Target() ;
        SetVelocity() ;
    }

    void UpdateDir()
    {
        if (playerAwareness.Aware) {
            targetDir = playerAwareness.PlayerDir ;
        }
        else {
            targetDir = Vector2.zero ;
        }
    }

   void Rotate2Target()
    {
        if (targetDir == Vector2.zero) {
            return ;
        }
        Quaternion targetRot = Quaternion.LookRotation(transform.forward,targetDir) ;
        Quaternion rotation = Quaternion.RotateTowards(transform.rotation,targetRot,rotSpeed*Time.deltaTime) ;
        rb.SetRotation(rotation) ;
    }

    void SetVelocity()
    {
        if (targetDir == Vector2.zero) {
            rb.velocity = Vector2.zero ;
        }
        else {
            rb.velocity = transform.up*speed ;
        }
    }
}
