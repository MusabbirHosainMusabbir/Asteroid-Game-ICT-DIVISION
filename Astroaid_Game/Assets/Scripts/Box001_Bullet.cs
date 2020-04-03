using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box001_Bullet : MonoBehaviour
{

    public GameObject Box001_bullet;
    public Transform Box001_bullet_out;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animy", 2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
     


    }
    void animy()
    {
        Instantiate(Box001_bullet, Box001_bullet_out.position, transform.rotation);

    }
}
