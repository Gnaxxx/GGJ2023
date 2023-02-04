using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform target;
    //private float range = 500.0f;
    Rigidbody2D rb;
    private float speed = 3.5f;
    Vector2 moveDirection;
    // Start is called before the first frame update

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Start()
    {
        target = GameObject.Find("Character").transform;
    }

    void Update()
    {
        //if (dist <= range)
        //{
        //transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        if (target)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            moveDirection = direction;
        }            
        //}
    }

    void FixedUpdate()
    {
        if (target)
        {
            rb.velocity = new Vector2(moveDirection.x, moveDirection.y) * speed;
        }
    }
}
