using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    public int firstDir = 1;//최초로 움직일 방향
    public float changeDirTime;//방향 전환까지 걸리는 시간

    int moveDir = 1;//현재 움직이는 방향

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
