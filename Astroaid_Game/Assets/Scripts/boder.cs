using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boder : MonoBehaviour
{

   
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "player_bullet")
        {
            Destroy(other.gameObject);


        }
        if (other.gameObject.tag == "Animy")
        {
            Destroy(other.gameObject);

        }

        if (other.gameObject.tag == "Animy_bullet")
        {
            Destroy(other.gameObject);


        }






        }
    }
