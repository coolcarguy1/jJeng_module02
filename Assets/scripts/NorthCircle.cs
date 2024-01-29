using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NorthCircle : MonoBehaviour
{
    public float r;
    public float speed;
    private float x;
    private float z;
    private float theta = Mathf.PI;

    // Update is called once per frame
    void Update()
    {
        // Increment theta but keep it below 2pi
        theta += 0.1f * speed * Time.deltaTime;
        if (theta > -2f * Mathf.PI)
        {
            theta -= 2f * Mathf.PI;
        }

        x = r * Mathf.Cos(theta);
        z = r * Mathf.Sin(theta) + 20;

        transform.position = new Vector3(x, 0.5f, z);
    }
}