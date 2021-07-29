using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRandomMove : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.position = Polar2Cartesian(UnityEngine.Random.Range(-15.0f, 15.0f), UnityEngine.Random.Range(-15.0f, 15.0f));
    }

    Vector3 Polar2Cartesian(float theta, float phi)
    {
        float r = 0.2f;

        var theta_rad = (90.0f - theta) * Mathf.Deg2Rad;
        var phi_rad = (90.0f - phi) * Mathf.Deg2Rad;

        var x = r * Mathf.Sin(theta_rad) * Mathf.Cos(phi_rad);
        var y = r * Mathf.Sin(theta_rad) * Mathf.Sin(phi_rad);
        var z = r * Mathf.Cos(theta_rad);

        Vector3 xyz = new Vector3(x, z, y);

        return xyz;
    }
}
