using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animy__ : MonoBehaviour
{
    public GameObject animy1;
    public Transform animy_out;
    public int score_value;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animy", 2f, 2f);
    }

    // Update is called once per frame
    void Update()
    {



    }
    void animy()
    {
        Instantiate(animy1, animy_out.position, transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        _score.score += score_value;
    }

}
