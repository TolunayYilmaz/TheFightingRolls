using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f;
    private Transform player;
    private Rigidbody rbEnemy;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rbEnemy=GetComponent<Rigidbody>();

    }

    
    void Update()
    { Vector3 lookDirection = (player.position - transform.position).normalized;
        rbEnemy.AddForce(lookDirection*speed*Time.deltaTime);
        if(transform.position.y < -2)
        {
            GameObject.Destroy(gameObject);       
        }
    }
   
}
