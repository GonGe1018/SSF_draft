using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text CatHP;//CatHP �ؽ�Ʈ
    public Text MouseHP;//MouseHP �ؽ�Ʈ

    //HP ������ �޾ƿ��� ���� ����
    public CatController CatController1;
    public CatController CatController2;
    public MouseController MouseController;

    bool gameOver = false;
    public GameObject winPanel;
    public GameObject losePanel;

    void Update()
    {
        HpUpdate();//HPupdate�Լ��� �� �����Ӹ��� �۵�
        overCheck();
    }

    void HpUpdate ()
    {
        CatHP.text = "����� HP : " + CatController1.HP.ToString()+
            " "+CatController2.HP.ToString();
        MouseHP.text = "�� HP : " + MouseController.HP.ToString(); 
        
    }

    void overCheck()
    {
        if (CatController1.isDied && CatController2.isDied && !gameOver)
        {
            gameOver = true;
            winPanel.SetActive(true);
        }
        if (MouseController.isDied && !gameOver)
        {
            gameOver = true;
            losePanel.SetActive(true);
        }
    }
}
