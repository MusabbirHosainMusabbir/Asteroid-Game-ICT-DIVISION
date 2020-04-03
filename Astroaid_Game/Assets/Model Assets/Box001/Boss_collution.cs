 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_collution : MonoBehaviour
{
    public Boss_Health_controller Boss_health_bar;



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
        if (other.gameObject.tag == "player_bullet")
        {
            if (Boss_health_bar)
            {
                Boss_health_bar.OnTakeDamage(5);
            }


        }




    }
}
