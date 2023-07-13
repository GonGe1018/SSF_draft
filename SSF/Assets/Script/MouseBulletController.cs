using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBulletController : MonoBehaviour
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
    {
        if(collision.CompareTag("Enemy"))
        {
            collision.gameObject.GetComponent<CatController>().HP -= 1;
        }
    }
}
