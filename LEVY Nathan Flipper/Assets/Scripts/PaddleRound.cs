using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleRound : MonoBehaviour
{
    public SpringJoint springJoint;
    public float defaultValue;
    public KeyCode key;
    public float currentValue;

    void Start()
    {
        defaultValue = springJoint.spring;
    }
    void Update()
    {
        
        
        if (Input.GetKey(key))
        {
            springJoint.spring = currentValue;
        }
        
        else
        {
            springJoint.spring = defaultValue;
        }

    }
}
