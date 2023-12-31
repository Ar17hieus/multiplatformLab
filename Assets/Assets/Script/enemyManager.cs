using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemyBarrel;
    [SerializeField] GameObject enemyShip;
    [SerializeField] GameObject enemyIsland;
    [SerializeField] gameManager GameManager;
    GameObject currentEnemy;

    float spawnTimer;
    [SerializeField]float whenToSpawn = 5;
    // Start is called before the first frame update
    void Start()
    {
       
        

    }

    // Update is called once per frame
    void Update()
    {
        if (!GameManager.getGameOver())
        {
            spawnTimer = spawnTimer + Time.deltaTime;

            // Debug.Log(spawnTimer);
            if (spawnTimer >= whenToSpawn)
            {
                spawnTimer = 0;

                if (!(whenToSpawn <= 0.5))
                {
                    whenToSpawn = whenToSpawn - 0.1f;
                }

                int spawnPos = Random.Range(-5, 5);
                int enemyType = Random.Range(1, 4);

                if (enemyType == 1)
                {
                    currentEnemy = enemyBarrel;
                }
                else if (enemyType == 2)
                {
                    currentEnemy = enemyShip;
                }
                else if (enemyType == 3)
                {
                    currentEnemy = enemyIsland;
                }

                Instantiate(currentEnemy, new Vector3(spawnPos, currentEnemy.GetComponent<Renderer>().bounds.size.y / 2, 100), currentEnemy.transform.rotation);
            }


        }



           

    }
}
