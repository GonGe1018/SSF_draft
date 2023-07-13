using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;//움직일 속도

    Vector2 MoveDir = Vector2.zero;//움직일 방향
    float Horinzontal;//수평축 이동 입력
    float Vertical;//수직축 이동 입력

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();//이동 함수 실행
    }

    void Move()
    {
        Horinzontal = Input.GetAxisRaw("Horizontal");//수평축 이동 입력
        Vertical = Input.GetAxisRaw("Vertical");//수직축 이동 입력

        MoveDir = new Vector2(Horinzontal, Vertical);//움직일 방향을 2차원 벡터로 저장

        transform.Translate(MoveDir * speed * Time.deltaTime);//움직일 방향과 속도를 곱하여 이동
    }
}
