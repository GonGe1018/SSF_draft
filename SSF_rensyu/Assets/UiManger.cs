using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManger : MonoBehaviour
{
    public Text CatHP;
    public Text PlayerHP;

    //죽음 여부를 알기 위한 선언
    public CatController catController1;
    public CatController catController2;
    public PlayerController playerController;

    bool gameOver = false;//게임오버 여부
    public GameObject winPanel;//승리 패널 
    public GameObject losePanel;//패배 패널

    void Update()
    {
        HpUpdate();
        overCheck();//게임오버 체크 함수
    }

    void HpUpdate()
    {
        CatHP.text = "고양이 HP : " + catController1.HP.ToString() +
            " " + catController2.HP.ToString();
        PlayerHP.text = "쥐 HP : " + playerController.HP.ToString();

    }

    void overCheck()
    {
        if(!gameOver)//게임이 끝났다면
        {
            if (catController1.isDied && catController2.isDied)
            //고양이 두 마리가 다 죽었다면
            {
                gameOver = true;//게임오버 체크
                winPanel.SetActive(true);//승리패널 활성화
            }
            if (playerController.isDied)
            {
                gameOver = true;//게임오버 체크
                losePanel.SetActive(true);//패배패널 활성화
            }
        }
    }
}
