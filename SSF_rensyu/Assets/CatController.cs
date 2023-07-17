using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int HP = 30;
    public bool isDied = false;

    public int firstDir = 1;
    public float changeDirTime;

    int moveDir = 1;

    float shotTimeMin = 0.3f;//발사 대기 최소 시간
    float shotTimeMax = 1f;//발사 대기 최대 시간

    public GameObject bullet;//총알 프리팹을 담는

    void Start()
    {
        StartCoroutine(MoveDirection());
        StartCoroutine(shot());//총알 발사 코루틴 시작
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveDir * firstDir * Time.deltaTime);
        if (HP <= 0)
        {
            isDied = true;
            gameObject.SetActive(false);
        }
    }

    IEnumerator MoveDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeDirTime);
            moveDir *= -1;
        }
    }
    IEnumerator shot()
    {
        float RandTime = Random.RandomRange
            (shotTimeMin, shotTimeMax);//랜덤한 대기 시간을 산출
        while (true)
        {
            Instantiate(bullet, 
                gameObject.transform.position, 
                gameObject.transform.rotation);//총알 복제

            yield return new WaitForSeconds(RandTime);
            //랜덤한 시간 동안 기다림
        }
    }
}

