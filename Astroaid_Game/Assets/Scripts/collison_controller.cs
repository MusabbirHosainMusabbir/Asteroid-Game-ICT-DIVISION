using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collison_controller : MonoBehaviour
{
    public health_bar_controoller health_bar;

    public GameObject game_over;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Animy_bullet")
        {
            if (health_bar)
            {
                health_bar.OnTakeDamage(10);
            }


        }
        if (other.gameObject.tag =="Animy")
        {
            if (health_bar)
            {
                health_bar.OnTakeDamage(10);
            }


        }
    }

 }


