using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    private Rigidbody rb;
    public float speed = 12f;
    private GameObject focalPoint;
    public bool powerUp = false;
    public float waitSecond=5;
    public GameObject powerUpIndicator;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("focalPoint");
     powerUpIndicator.SetActive(false);
    }

  
    void Update()
    {
        float inputVertical = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward * speed * inputVertical * Time.deltaTime);
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("powerUp"))
        {
            Debug.Log("G��lendi");
            powerUp = true;
            Destroy(other.gameObject);
            StartCoroutine(powerDown());//The purpose of the coroutine is to make the player have a powerdown after 5 seconds when he gets a powerup
            powerUpIndicator.SetActive(true);
        }
    }

    IEnumerator powerDown()
    {
        yield return new WaitForSeconds(5);
        powerUp=false;
        powerUpIndicator.SetActive(false);  
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && powerUp)
        {// G��lendirme alan player
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 addForceEnemy = collision.gameObject.transform.position - transform.position;//player ve enemy aras�ndaki mesafe fark�
            enemyRb.AddForce(addForceEnemy*3,ForceMode.Impulse);//enemy uygulad��� g��
           
            Debug.Log("D��man " + collision.gameObject.name + "G��: " + powerUp);
        }
    }
}