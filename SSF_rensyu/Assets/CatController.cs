using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int firstDir = 1;//���ʷ� ������ ����
    public float changeDirTime;//���� ��ȯ���� �ɸ��� �ð�

    int moveDir = 1;//���� �����̴� ����

    void Start()
    {
        StartCoroutine(MoveDirection());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * moveDir * firstDir * Time.deltaTime);
    }

    IEnumerator MoveDirection()
    {
        while (true)
        {
            yield return new WaitForSeconds(changeDirTime);
            moveDir *= -1;
        }
    }
}
