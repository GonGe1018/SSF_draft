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
    //만약 Collider의 Triger충돌이 있었다면
    {
        if (collision.CompareTag("Enemy"))
        //충돌한 대상의 태그가 Enemy라면
        {
            collision.GetComponent<CatController>().HP -= 1;
            //충돌한 대상의 체력을 1 낮춤
            Destroy(gameObject);
            //총알을 삭제함
        }
    }
}
