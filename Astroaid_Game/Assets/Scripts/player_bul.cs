using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_bul : MonoBehaviour
{
    

    public int Scorevalue;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -0.5f);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Animy")
        {
            
            Destroy(other.gameObject);
            Destroy(this.gameObject);

            _score.score += Scorevalue;
           

        }
        if (other.gameObject.tag == "Animy_bullet")
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            _score.score += Scorevalue;
            
        }
    }

  
}

