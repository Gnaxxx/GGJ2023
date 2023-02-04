using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject target;
    public float range;
    public float speed;
    // Start is called before the first frame update
    void MoveTowardPlayer()
    {
        float dist = Vector3.Distance(target.transform.position, transform.position);
        if (dist <= range)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
        }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveTowardPlayer();

    }
}
