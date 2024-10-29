using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public SpringJoint springJoint;
    public float defaultValue;
    public KeyCode key;
    public float minValue;
    public float currentValue;
    public float incrementSpeed = 1;
    private Vector3 position;
    
    void Start()
    {
        defaultValue = springJoint.spring;
    }
    void Update()
    {
        
        
        if (Input.GetKey(key))
        {
            position = transform.position;
            position.y += 0.001f;
            transform.position = position;
            if (currentValue > minValue)
            {
                currentValue -= incrementSpeed;
            }
                
            
        }
            

        else
        {
            currentValue = defaultValue;
        }

        springJoint.spring = currentValue;

    }
}
