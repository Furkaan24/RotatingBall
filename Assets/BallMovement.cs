using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform cubeTransform;
    public float baseSpeed;
    public float maxSpeed;
    public float acceleration;
    public TrailRenderer trail;

    private float currentSpeed;

    void Start()
    {
        trail.enabled = false;
        currentSpeed = baseSpeed;
    }

    void Update()
    {
            Vector3 axis = new Vector3(baseSpeed, 0f, -baseSpeed).normalized;
            transform.RotateAround(cubeTransform.position, axis, currentSpeed * Time.deltaTime);
            trail.enabled = true;
    }
}
