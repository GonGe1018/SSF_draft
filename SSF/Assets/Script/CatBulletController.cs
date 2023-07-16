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
    {
        if(collision.CompareTag("Player"))
        {
            collision.GetComponent<MouseController>().HP -= 1;
            Destroy(gameObject);
        }
    }
}
