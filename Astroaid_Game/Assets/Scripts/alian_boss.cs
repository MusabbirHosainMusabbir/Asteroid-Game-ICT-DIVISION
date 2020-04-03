using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alian_boss : MonoBehaviour
{
    public GameObject animy1;
    public Transform animy_out1;
    public int score_value;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animy", 15f, 15f);
    }

    // Update is called once per frame
  
    void animy2()
    {
        Instantiate(animy1, animy_out1.position, transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        _score.score += score_value;
    }

}
