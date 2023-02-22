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
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Space))
        {
            currentSpeed = Mathf.Min(currentSpeed + acceleration * Time.deltaTime, maxSpeed);
        }
        else
        {
            currentSpeed = baseSpeed;
        }

        if (horizontalInput != 0f || verticalInput != 0f)
        {
            Vector3 axis = new Vector3(verticalInput, 0f, -horizontalInput).normalized;
            transform.RotateAround(cubeTransform.position, axis, currentSpeed * Time.deltaTime);
            trail.enabled = true;
        }
        else
        {
            trail.enabled = false;
        }
    }
}
