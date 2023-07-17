using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int HP = 30;
    public bool isDied = false;


    public float speed = 3f;

    Vector2 MoveDir = Vector2.zero;
    float Horizontal;
    float Vertical;

    public GameObject bullet;//총알 프리팹을 담는

    void Start()
    {
        StartCoroutine(Shot());//총알 발사 코루틴 시작
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (HP <= 0)
        {
            isDied = true;
            gameObject.SetActive(false);
        }
    }

    void Move()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        MoveDir = new Vector2(Horizontal, Vertical);

        transform.Translate(MoveDir * speed * Time.deltaTime);
    }

    IEnumerator Shot()
    {
        while(true)//무한 반복
        {
            Instantiate(bullet, gameObject.transform.position,
                gameObject.transform.rotation);//총알 복사
            yield return new WaitForSeconds(0.3f);//0.3초 대기
        }
    }
}
