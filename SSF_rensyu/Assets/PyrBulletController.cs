using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyrBulletController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up*500f);
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
        if (collision.CompareTag("Enemy"))
        //�浹�� ����� �±װ� Enemy���
        {
            collision.GetComponent<CatController>().HP -= 1;
            //�浹�� ����� ü���� 1 ����
            Destroy(gameObject);
            //�Ѿ��� ������
        }
    }
}
