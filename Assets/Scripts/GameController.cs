using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timer = 300.0f;
    private float timeBeforeSpawning = 1.5f;
    private float timeBeforeWaves = 2.0f;
    private float enemiesPerWave;
    private int difficultyCounter = 0;
    Transform enemy;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        enemy = GameObject.Find("Potato").transform;
        player = GameObject.Find("Character").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            SpawnEnemies();

        }
    }

    void SpawnEnemies()
    {

        if (timer > 290.0f)
        {
            enemiesPerWave = 5.0f;
        }

        for (int i = 0; i < enemiesPerWave; i++)
        {
            float randDistance = Random.Range(5.0f, 7.0f);
            float randDirection = Random.Range(0.0f, 360.0f);
            float posX = player.transform.position.x + (Mathf.Cos((randDirection) * Mathf.Deg2Rad) * randDistance);
            float posY = player.transform.position.y + (Mathf.Sin((randDirection) * Mathf.Deg2Rad) * randDistance);

            Instantiate(enemy, new Vector3(posX, posY, 0), this.transform.rotation);
        }
    }
}
