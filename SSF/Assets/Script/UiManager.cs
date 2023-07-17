using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text CatHP;//CatHP 텍스트
    public Text MouseHP;//MouseHP 텍스트

    //HP 정보를 받아오기 위한 선언
    public CatController CatController1;
    public CatController CatController2;
    public MouseController MouseController;
    void Update()
    {
        HpUpdate();//HPupdate함수를 매 프레임마다 작동
    }

    void HpUpdate ()
    {
        CatHP.text = "고양이 HP : " + CatController1.HP.ToString()+
            " "+CatController2.HP.ToString();
        MouseHP.text = "쥐 HP : " + MouseController.HP.ToString(); 
        
    }
}
