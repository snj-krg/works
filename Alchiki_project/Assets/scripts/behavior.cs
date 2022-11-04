using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behavior : MonoBehaviour
{
    private bool Movement = false;
    float turnSpeed = 50f;
    float acceleration = 900f;
    void Start()
    {

    }


    void Update()
    {  if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.forward * -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space) && Movement == false)
        {
            transform.Translate(Vector2.up * acceleration * Time.deltaTime);
            Movement = true;
        }
    }
  
}
