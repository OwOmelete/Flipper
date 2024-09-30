using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingBar : MonoBehaviour
{
    public Vector3 positionInitiale;
    public Quaternion rotationInitiale;
    public KeyCode key;
    public GameObject fume;

    void Start()
    {
        positionInitiale = transform.position;
        rotationInitiale = transform.rotation;
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Instantiate(fume, transform.position, transform.rotation);
            transform.position = positionInitiale;
            transform.rotation = rotationInitiale;

        }
    }
}
