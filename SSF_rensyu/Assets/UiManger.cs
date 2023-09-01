using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManger : MonoBehaviour
{
    public Text CatHP;
    public Text PlayerHP;

    //���� ���θ� �˱� ���� ����
    public CatController catController1;
    public CatController catController2;
    public PlayerController playerController;

    bool gameOver = false;//���ӿ��� ����
    public GameObject winPanel;//�¸� �г� 
    public GameObject losePanel;//�й� �г�

    void Update()
    {
        HpUpdate();
        overCheck();//���ӿ��� üũ �Լ�
    }

    void HpUpdate()
    {
        CatHP.text = "����� HP : " + catController1.HP.ToString() +
            " " + catController2.HP.ToString();
        PlayerHP.text = "�� HP : " + playerController.HP.ToString();

    }

    void overCheck()
    {
        if(!gameOver)//������ �����ٸ�
        {
            if (catController1.isDied && catController2.isDied)
            //����� �� ������ �� �׾��ٸ�
            {
                gameOver = true;//���ӿ��� üũ
                winPanel.SetActive(true);//�¸��г� Ȱ��ȭ
            }
            if (playerController.isDied)
            {
                gameOver = true;//���ӿ��� üũ
                losePanel.SetActive(true);//�й��г� Ȱ��ȭ
            }
        }
    }
}
