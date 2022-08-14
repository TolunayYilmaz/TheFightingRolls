using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyLocation = 9;
    public GameObject Enemy;
    public float startTime = 2f;
    public float repeatTime = 4f;
    public int enemyCount;
    public int enemyCountIncrease = 1;
    public GameObject powerUp;

    private void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            enemyCountIncrease++;// When the enemies are gone, one more comes
            enemySpawn(enemyCountIncrease);

        }


    }


    void enemySpawn(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(Enemy, CreateLocation(), Enemy.transform.rotation);//With the for loop, the enemy is increasing.
            Instantiate(powerUp, CreateLocation(), powerUp.transform.rotation);



        }
        Vector3 CreateLocation()
        {
            float spawmLocationX = Random.Range(-enemyLocation, enemyLocation);
            float spawmLocationZ = Random.Range(-enemyLocation, enemyLocation);
            Vector3 Location = new Vector3(spawmLocationX, 0, spawmLocationZ);

            return Location;

        }
    }
}
