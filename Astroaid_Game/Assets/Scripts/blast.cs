using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast : MonoBehaviour
{
    
    public GameObject effict;
    void Start()
    {
        effict =GameObject.Find("Eff_Burst_1_loop");
        effict.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);

        effict.SetActive(true);
    }
}
