using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimWeapon : MonoBehaviour
{
    public Transform aimTransform ;
    public Camera cam ;

    Vector3 mousePos ;

    public void Awake()
    {
        aimTransform = transform.Find("Gun") ;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition) ; 
    }

    void FixedUpdate()
    {
        Vector3 lookDir = mousePos - transform.position ;
        float angle = Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg ;
        aimTransform.eulerAngles = new Vector3(0,0,angle) ;
    }
}
