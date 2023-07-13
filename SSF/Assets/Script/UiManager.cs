using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text CatHP;
    public Text MouseHP;

    public CatController CatController1;
    public CatController CatController2;
    public MouseController MouseController;

    // Update is called once per frame
    void Update()
    {
        HpUpdate();
    }

    void HpUpdate ()
    {
        CatHP.text = "∞ÌæÁ¿Ã HP : " + CatController1.HP.ToString()+" "+CatController2.HP.ToString();
        MouseHP.text = "¡„ HP : " + MouseController.HP.ToString();   
    }
}
