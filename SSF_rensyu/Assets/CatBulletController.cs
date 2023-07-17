using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBulletController : MonoBehaviour
{

    void Start()
    {
        StartCoroutine(objectDestroy());
    }

    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    //���� Collider�� Triger�浹�� �־��ٸ�
    {
        if (collision.CompareTag("Player"))
        //�浹�� ����� �±װ� Player���
        {
            collision.GetComponent<PlayerController>().HP -= 1;
            //�浹�� ����� ü���� 1 ����
            Destroy(gameObject);
            //�Ѿ��� ������
        }
    }
}
