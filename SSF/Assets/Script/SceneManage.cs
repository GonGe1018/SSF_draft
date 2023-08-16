using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{
    
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
