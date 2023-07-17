using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBulletController : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(objectDestroy());//발사 후 총알이 삭제 되도록함
    }

    IEnumerator objectDestroy()
    {
        yield return new WaitForSeconds(3.0f);//3초 동안 기다림
        Destroy(gameObject);//게임오브젝트(총알)을 삭제함
    }
}
