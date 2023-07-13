using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3f;//������ �ӵ�

    Vector2 MoveDir = Vector2.zero;//������ ����
    float Horinzontal;//������ �̵� �Է�
    float Vertical;//������ �̵� �Է�

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();//�̵� �Լ� ����
    }

    void Move()
    {
        Horinzontal = Input.GetAxisRaw("Horizontal");//������ �̵� �Է�
        Vertical = Input.GetAxisRaw("Vertical");//������ �̵� �Է�

        MoveDir = new Vector2(Horinzontal, Vertical);//������ ������ 2���� ���ͷ� ����

        transform.Translate(MoveDir * speed * Time.deltaTime);//������ ����� �ӵ��� ���Ͽ� �̵�
    }
}
