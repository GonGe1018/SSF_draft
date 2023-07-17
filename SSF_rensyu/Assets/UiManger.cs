using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManger : MonoBehaviour
{
    public Text CatHP;//CatHP �ؽ�Ʈ
    public Text PlayerHP;//PlayerHP �ؽ�Ʈ

    //HP ������ �޾ƿ��� ���� ����
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
        CatHP.text = "����� HP : " + catController1.HP.ToString() +
            " " + catController2.HP.ToString();
        PlayerHP.text = "�� HP : " + playerController.HP.ToString();

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
