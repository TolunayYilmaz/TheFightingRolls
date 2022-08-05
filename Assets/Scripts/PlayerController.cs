using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody rb;
    public float speed=12f;
    private GameObject focalPoint;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("focalPoint");
    }

    // Update is called once per frame
    void Update()
    { 
        float inputVertical = Input.GetAxis("Vertical");
        rb.AddForce(focalPoint.transform.forward*speed* inputVertical*Time.deltaTime);
    }
}