using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backround_muve : MonoBehaviour
{
    public float ScrollSpeed;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    private void Update()
    {
        float ofset = Time.time * ScrollSpeed;
        rend.material.SetTextureOffset("_MainTex",new Vector2(0,ofset));
    }
}
