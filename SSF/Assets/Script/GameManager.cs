using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameOver =false;
    public GameObject winPanel;
    public GameObject losePanel;

    public CatController cat1;
    public CatController cat2;

    public MouseController mouse;

    private void Update()
    {
        if (cat1.isDied && cat2.isDied&&!gameOver)
        {
            gameOver = true;
            winPanel.SetActive(true);
        }
        if (mouse.isDied && !gameOver)
        {
            gameOver = true;
            losePanel.SetActive(true);
        }
    }
}
