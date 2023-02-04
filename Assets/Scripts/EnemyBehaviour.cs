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
        //Destroy(gameObject);
        if (col.collider.gameObject.CompareTag("Character"))
        {
            target.GetComponent<PlayerStats>().takeDamage(10.0f);
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
            float varience = ((target.position - transform.position).magnitude);
            float randomX = Random.Range(-1.0f * varience, 1.0f * varience);
            float randomY = Random.Range(-1.0f * varience, 1.0f * varience);
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
