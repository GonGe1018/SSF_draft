using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBulletController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(objectDestroy());//�߻� �� �Ѿ��� ���� �ǵ�����
    }

    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);//3�� ���� ��ٸ�
        Destroy(gameObject);//���ӿ�����Ʈ(�Ѿ�)�� ������
    }
}
