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
    void Update()
    {
        HpUpdate();//HPupdate�Լ��� �� �����Ӹ��� �۵�
    }

    void HpUpdate ()
    {
        CatHP.text = "����� HP : " + CatController1.HP.ToString()+
            " "+CatController2.HP.ToString();
        MouseHP.text = "�� HP : " + MouseController.HP.ToString(); 
        
    }
}
