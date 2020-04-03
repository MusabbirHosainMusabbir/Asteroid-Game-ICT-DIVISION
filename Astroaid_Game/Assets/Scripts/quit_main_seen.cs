using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit_main_seen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("manu");
    }
    public void restart()
    {
        SceneManager.LoadScene("Level_1");
    }
    public void QuitGame()
    {
        Debug.Log("application Is Quit");
        Application.Quit();
    }
    public void Home()
    {
        SceneManager.LoadScene("manu");
    }
}