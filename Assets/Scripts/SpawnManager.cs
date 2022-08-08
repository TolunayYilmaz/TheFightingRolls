using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    private float enemyLocation=9;
    public GameObject Enemy;
    public float startTime = 2f;
    public float repeatTime = 4f;
    void Start()
    {
        InvokeRepeating("CreateEnemyInvoke", startTime, repeatTime);
        
    }


    void CreateEnemyInvoke()
    {
        enemySpawn(4);
    }
    void enemySpawn(int enemyToSpawn)
    {
        for (int i = 0; i < enemyToSpawn; i++)
        {
            Instantiate(Enemy, CreateLocation(), Enemy.transform.rotation);// for dögüsü sayesinde düþman giitkçe artacak
        }
    }
    Vector3 CreateLocation()
    {
        float spawmLocationX = Random.Range(-enemyLocation, enemyLocation);
        float spawmLocationZ = Random.Range(-enemyLocation, enemyLocation);
        Vector3 Location = new Vector3(spawmLocationX, 0, spawmLocationZ);

        return Location;

    }
}
