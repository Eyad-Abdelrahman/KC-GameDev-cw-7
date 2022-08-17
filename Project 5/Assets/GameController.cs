using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnRight;
    public Transform spawnLeft;
    public float delay;

    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        int randm = Random.Range(1 , 4);
        if (randm == 1)
        {
            Instantiate(enemy, spawnLeft);

            }
        else if (randm == 2)
        {
            Instantiate(enemy, spawn);

        }
        else
        {
            Instantiate(enemy, spawnRight); 
        }
        
    }
   
    }

