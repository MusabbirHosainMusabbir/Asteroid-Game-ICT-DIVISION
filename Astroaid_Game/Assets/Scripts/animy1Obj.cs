using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animy1Obj : MonoBehaviour
{
    
    public GameObject bullet;
    public Transform bulletposition;


    void Update()
    {




    }
    void shoot()
    {
        Instantiate(bullet, bulletposition.position, transform.rotation);
    }



}
