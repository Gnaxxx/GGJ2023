using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Transform target;
    //private float range = 500.0f;
    Rigidbody2D rb;
    public float speed = 3.5f;
    private Vector2 moveDirection;
    
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("Character"))
        {
            Debug.Log("WAWASDASDASD");
        }
    }
    
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
        if (target)
        {
            float randomX = Random.Range(-6.0f, 6.0f);
            float randomY = Random.Range(-6.0f, 6.0f);
            Vector3 directionRange = new Vector3 (randomX, randomY, 0.0f);

            Vector3 direction = (target.position + directionRange - transform.position).normalized;
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
