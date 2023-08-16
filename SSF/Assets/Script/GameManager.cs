using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void clickStart()
    {
        SceneManager.LoadScene("GameScene");
        //게임씬 로드
    }
    public void clickExit()
    {
        Application.Quit();
        //애플리케이션 종료
    }
    public void clickMenu()
    {
        SceneManager.LoadScene("MenuScene");
        //메뉴씬 로드
    }
}
