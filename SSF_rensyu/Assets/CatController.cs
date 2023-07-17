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

    float shotTimeMin = 0.3f;//�߻� ��� �ּ� �ð�
    float shotTimeMax = 1f;//�߻� ��� �ִ� �ð�

    public GameObject bullet;//�Ѿ� �������� ���

    void Start()
    {
        StartCoroutine(MoveDirection());
        StartCoroutine(shot());//�Ѿ� �߻� �ڷ�ƾ ����
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
            (shotTimeMin, shotTimeMax);//������ ��� �ð��� ����
        while (true)
        {
            Instantiate(bullet, 
                gameObject.transform.position, 
                gameObject.transform.rotation);//�Ѿ� ����

            yield return new WaitForSeconds(RandTime);
            //������ �ð� ���� ��ٸ�
        }
    }
}

