using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animy_animation : MonoBehaviour
{
    public GameObject animy_animation_1;
    public Transform animy_out;
    public int score_value;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("animy", 10f, 10f);
    }

    // Update is called once per frame
    void Update()
    {

    
    }
    void animy()
    {
        Instantiate(animy_animation_1, animy_out.position, transform.rotation);
    }
    private void OnCollisionEnter(Collision collision)
    {
        _score.score += score_value;
    }




}
