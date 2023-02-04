using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    Transform player;
    public ProjectileStats Stats;
    private Vector3 direction;
    private int hits;
    // Start is called before the first frame update
    void Start()
    {
        hits = Stats.hits;
        float randX = Random.Range(-1.0f, 1.0f);
        float randY = Random.Range(-1.0f, 1.0f);
        if (randX == 0.0f && randY == 0.0f)
        {
            randX = 1.0f;
        }
        direction.x = randX;
        direction.y = randY;
        direction.z = 0.0f;

        direction = direction.normalized;

        player = GameObject.Find("Character").transform;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //Destroy(gameObject);
        if (col.collider.gameObject.CompareTag("Enemy"))
        {
            col.collider.gameObject.GetComponent<EnemyBehaviour>().takeDamage(Stats.damage);
            hits--;
            if (hits == 0)
            {
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Stats.speed * Time.deltaTime;

        float varience = ((player.position - transform.position).magnitude);
        if (varience > 25)
        {
            Destroy(gameObject);
        }
    }
}
