using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyrBulletController : MonoBehaviour
{
    Rigidbody2D rigidbody;//Rigidbody2D ������Ʈ�� ���� ����
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();//Rigidbody2D�� ������ ������ ����
        rigidbody.AddForce(transform.up*500f);//���� ���ؼ� �Ѿ� �߻�
        StartCoroutine(objectDestroy());//�߻� �� �Ѿ��� ���� �ǵ�����
    }
    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);//3�� ���� ��ٸ�
        Destroy(gameObject);//���ӿ�����Ʈ(�Ѿ�)�� ������
    }
}
