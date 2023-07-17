using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManger : MonoBehaviour
{
    public Text CatHP;//CatHP 텍스트
    public Text PlayerHP;//PlayerHP 텍스트

    //HP 정보를 받아오기 위한 선언
    public CatController catController1;
    public CatController catController2;
    public PlayerController playerController;

    bool gameOver = false;
    public GameObject winPanel;
    public GameObject losePanel;


    void Update()
    {
        HpUpdate();
        overCheck();
    }

    void HpUpdate()
    {
        CatHP.text = "고양이 HP : " + catController1.HP.ToString() +
            " " + catController2.HP.ToString();
        PlayerHP.text = "쥐 HP : " + playerController.HP.ToString();

    }

    void overCheck()
    {
        if (catController1.isDied && catController2.isDied && !gameOver)
        {
            gameOver = true;
            winPanel.SetActive(true);
        }
        if (playerController .isDied && !gameOver)
        {
            gameOver = true;
            losePanel.SetActive(true);
        }

    }
}
