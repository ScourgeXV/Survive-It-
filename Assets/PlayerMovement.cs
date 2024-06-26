using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 2f ;
    public Rigidbody2D rb ;
    public Camera cam ;

    Vector2 movement ;
    Vector2 mousePos ;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal") ;
        movement.y = Input.GetAxisRaw("Vertical") ;
    }

    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement*moveSpeed*Time.fixedDeltaTime) ;
    }
}
