using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public GameObject bullet;

    public int HP = 30;
    public bool isDied = false;

    public float speed = 3f;
    Vector2 MoveDir = Vector2.zero;
    float Horinzontal;
    float Vertical;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(Shot());
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        if (HP <= 0)
        {
            isDied = true;
            gameObject.SetActive(false);
        }
    }

    void Move()
    {
        Horinzontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        MoveDir = new Vector2(Horinzontal, Vertical);

        transform.Translate(MoveDir * speed * Time.deltaTime);
    }


    IEnumerator Shot()
    { 
        while (true)
        {
            Instantiate(bullet, gameObject.transform.position,gameObject.transform.rotation);
            yield return new WaitForSeconds(0.3f);
        }
    }
}
