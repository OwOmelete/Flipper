using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPosition : MonoBehaviour
{
    private Vector3 position; 
    Vector3 vel;
    void Start()
    {
        position = transform.position;
        vel = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = position;
            GetComponent<Rigidbody>().velocity = vel;

        }
    }
}
