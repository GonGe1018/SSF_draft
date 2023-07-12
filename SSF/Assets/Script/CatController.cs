using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int HP = 100;

    int moveDir = 1;

    float shotTimeMin = 0.3f;
    float shotTimeMax = 1f;

    public GameObject bullet;

    private void Start()
    {
        StartCoroutine(MoveDirection());
        StartCoroutine(shootBullet());
    }

    private void Update()
    {
        transform.Translate(Vector3.right*moveDir*Time.deltaTime);
    }

    IEnumerator MoveDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(6f);
            moveDir *= -1;
        }
    }

    IEnumerator shootBullet()
    {
        float RandTime = Random.RandomRange(shotTimeMin, shotTimeMax);
        while(true)
        {
            Instantiate(bullet,gameObject.transform.position,gameObject.transform.rotation);
            yield return new WaitForSeconds(RandTime);
        }
        
    }
}
