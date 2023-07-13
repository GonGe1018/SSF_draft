using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    private void Awake()
    {
    }

    private void Update()
    {
        Screen.SetResolution(480, 854, false);
    }
    public void clickStart()
   {
        SceneManager.LoadScene("GameScene");
   }

    public void clickExit()
    { 
        Application.Quit();
    }
    
    public void clickMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

}
