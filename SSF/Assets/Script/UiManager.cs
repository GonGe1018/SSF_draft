using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    public Text CatHP;
    public Text MouseHP;

    public CatController CatController;
    public MouseController MouseController;

    // Update is called once per frame
    void Update()
    {
        HpUpdate();
    }

    void HpUpdate ()
    {
        CatHP.text = "∞ÌæÁ¿Ã HP : " + CatController.HP.ToString();
        MouseHP.text = "¡„ HP : " + MouseController.HP.ToString();   
    }
}
