using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public float timer = 300.0f;
    private float timeBeforeSpawning = 1.5f;
    private float timeBeforeWaves = 2.0f;
    private float timeBetweenSpawn = 0.7f;
    private float enemiesPerWave;
    private int difficultyCounter = 0;
    public Transform[] enemy;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        //enemy = GameObject.Find("Potato").transform;
        player = GameObject.Find("Character").transform;
        InvokeRepeating("SpawnEnemies",5.0f, 5.0f);
        //SpawnEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            Debug.Log(timer);

        }
    }

    

    void SpawnEnemies()
    {
        

        if (timer > 290.0f)
        {
            enemiesPerWave = 10.0f;
        }

        for (int i = 0; i < enemiesPerWave; i++)
        {
            float randDistanceX = Random.Range(-20.0f, 20.0f);
            float randDistanceY = Random.Range(-20.0f, 20.0f);
            float playerPosX = player.position.x;
            float playerPosY = player.position.y;
            int randomEnemy = Random.Range(0, 2);

            Instantiate(enemy[randomEnemy], new Vector3(playerPosX + randDistanceX, playerPosY + randDistanceY, 0), enemy[randomEnemy].rotation);
            //yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }
}
