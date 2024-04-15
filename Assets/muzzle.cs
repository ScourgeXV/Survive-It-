using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzzle : MonoBehaviour
{
//    public Transform Muzzle ;
    public GameObject muzzlePrefab ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            GameObject m = Instantiate(muzzlePrefab,transform.position,transform.rotation) ;
            Destroy(m,0.5f) ;
        }
    }
}
