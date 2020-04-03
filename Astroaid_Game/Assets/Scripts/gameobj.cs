using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobj : MonoBehaviour
{

    public GameObject bullet;
    public Transform bulletposition;

    private void Start()
    {
        InvokeRepeating("shoot", 1f, 0.50f);
    }


    void Update()
    {

     


    }
    void shoot()
    {
        Instantiate(bullet, bulletposition.position, transform.rotation);
        
    }
}
