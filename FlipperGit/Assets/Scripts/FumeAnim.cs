using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FumeAnim : MonoBehaviour
{
    
    public KeyCode key;
    public Animation anim;
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            anim.Play("Fume3");
        }
    }
}
