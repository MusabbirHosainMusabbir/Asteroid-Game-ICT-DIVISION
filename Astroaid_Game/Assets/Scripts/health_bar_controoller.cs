
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class health_bar_controoller : MonoBehaviour
{
    public Image health_bar;
    public float health;
    public float stert_helth;
    public GameObject game_over;
    public GameObject Blast;

  
   
     public void OnTakeDamage(float damage)
    {
        health = health - damage;
        health_bar.fillAmount = health / stert_helth;
        if (health < 0)
        {
            //Destroy(this);
            //game_over.SetActive(true);
            SceneManager.LoadScene("LOSE");
           // Blast.SetActive(true);
        }
    }
    
}
