using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Booster : MonoBehaviour
{
    public GameObject orientation;
    private Vector3 boost;
    public float force;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 boost = (orientation.transform.position - transform.position).normalized * force;
        Rigidbody ball = other.GetComponent<Rigidbody>();
        ball.velocity = new Vector3(0, 0, 0);
        other.GetComponent<Rigidbody>().AddForce(boost,ForceMode.Impulse);
    }

    
}
