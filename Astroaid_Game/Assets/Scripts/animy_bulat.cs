using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animy_bulat : MonoBehaviour
{

    
    float speed;
    GameObject target;

    public GameObject animy1;
    public Transform animy_out;

    // Start is called before the first frame update
    void Start()
    {
       
        speed = 4f;
        target = GameObject.Find("Player");
        InvokeRepeating("animy", 1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -0.20f);
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);


    }
    void animy()
    {
        Instantiate(animy1, animy_out.position, transform.rotation);

    }
   

}


