using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _score : MonoBehaviour
{
    public static int score;
    public Text score_text;
    public GameObject stopAnime;
    public GameObject Boss001;






    private void Awake()
    {
        //   stopAnime = GameObject.Find("my_animy_IS/");

        score_text = GetComponent<Text>();
        score = 0;

        Boss001 = GameObject.Find("Box001");



    }
    private void Start()

    {
        //   stopAnime.SetActive(true);

    }
    private void Update()
    {
        score_text.text = "" + score;



       


    }
    void BOS001()
    {
        if (score == 100)
        {
            // stopAnime.SetActive(false);
            Boss001.SetActive(true);
        }
    }
}





