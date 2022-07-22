using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;


    private float timeBtwSpawn;
    [SerializeField] private float startTimeBtwSpawn;


    private void Update()
    {
        Spawn();
       
    }

    void Spawn()
    {     
        if (timeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);

            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);

            timeBtwSpawn = startTimeBtwSpawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;

        }
    }     
}
