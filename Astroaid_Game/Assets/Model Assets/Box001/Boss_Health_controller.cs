using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Boss_Health_controller : MonoBehaviour
{
    public Image Boss_health_bar;
    public float Boss_health;
    public float Boss_stert_helth;
    public GameObject BossShif;
    public GameObject Blast_Boss;



    // Start is called before the first frame update
    void Start()
    {
        BossShif = GameObject.Find("Box001");




    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTakeDamage(float damage)
    {
        Boss_health = Boss_health - damage;
        Boss_health_bar.fillAmount = Boss_health / Boss_stert_helth;
        if (Boss_health < 0)
        {
             Destroy(BossShif);
            // LavelComplete.SetActive(true);
            Instantiate(Blast_Boss, BossShif.transform.position, Quaternion.identity);


            Invoke("levelComplete", 10f);
            


        }

        
        
    }

    public void levelComplete()
    {
          SceneManager.LoadScene("WINNING");
    }
   
}
