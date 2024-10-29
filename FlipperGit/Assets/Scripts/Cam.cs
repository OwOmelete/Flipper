using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject ball;
    public float smoothness;
    void Start()
    {
        
    }
    
    void Update()
    {
        Vector3 ballPos = ball.transform.position;
        ballPos.z += -9;
        Vector3 camPos = transform.position;
        transform.position = Vector3.Lerp(camPos, ballPos, smoothness);

    }
}
