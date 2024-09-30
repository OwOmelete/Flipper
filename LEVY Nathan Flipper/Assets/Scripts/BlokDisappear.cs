using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BlokDisappear : MonoBehaviour
{
    public KeyCode key;
    public KeyCode key2;
    
    
    void Update()
    {
        
        if (Input.GetKeyDown(key))
        {
            GetComponent<BoxCollider>().enabled = false;
        }
        else
        {
            if (Input.GetKeyDown(key2))
            {
                GetComponent<BoxCollider>().enabled = true;
            }
        }
        
    }
}
