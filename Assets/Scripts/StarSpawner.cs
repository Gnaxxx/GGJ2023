using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{

    public float frequency;
    public GameObject starPrefab;


    void Awake()
    {
        StartCoroutine(StartSpawning());
    }

    private IEnumerator StartSpawning()
    {
        while (true)
        {
            Instantiate(starPrefab, new Vector3(transform.position.x, transform.position.y, 0.0f), Quaternion.identity);
            yield return new WaitForSeconds(frequency);
        }
    }
}
