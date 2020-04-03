using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAi : MonoBehaviour
{

    GameObject target;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 4f;
        target = GameObject.Find("Asteroid 1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
    }
}
