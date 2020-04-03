using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animy_animation1 : MonoBehaviour
{
    public GameObject animy1;
    public Transform animy_out;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animy", 0.5f, 0.7f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -0.1f);



    }
    void animy()
    {
        Instantiate(animy1, animy_out.position, transform.rotation);
    }

}
