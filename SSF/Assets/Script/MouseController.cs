using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    public Rigidbody2D rigidbody; 
    
    public int HP = 100;

    public float speed = 3f;
    Vector2 MoveDir = Vector2.zero;
    float Horinzontal;
    float Vertical;

    // Start is called before the first frame update
    void Awake()
    {
        //rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Horinzontal = Input.GetAxisRaw("Horizontal");
        Vertical = Input.GetAxisRaw("Vertical");

        MoveDir = new Vector2(Horinzontal, Vertical);

        rigidbody.velocity += MoveDir * speed * Time.deltaTime;
    }
}
