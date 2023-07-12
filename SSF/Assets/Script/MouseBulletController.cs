using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBulletController : MonoBehaviour
{
    Rigidbody2D rigidbody;
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.AddForce(transform.up*3f);
        StartCoroutine(objectDestroy());
    }

    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);
        Destroy(gameObject);
    }
}
