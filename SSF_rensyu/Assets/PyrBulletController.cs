using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyrBulletController : MonoBehaviour
{
    Rigidbody2D rigidbody;//Rigidbody2D 컴포넌트를 담을 변수
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();//Rigidbody2D를 가져와 변수에 담음
        rigidbody.AddForce(transform.up*500f);//힘을 가해서 총알 발사
        StartCoroutine(objectDestroy());//발사 후 총알이 삭제 되도록함
    }
    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);//3초 동안 기다림
        Destroy(gameObject);//게임오브젝트(총알)을 삭제함
    }
}
