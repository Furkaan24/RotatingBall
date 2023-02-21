using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform cubeTransform;  // The transform component of the cube
    public float speed; // The speed of rotation
    public TrailRenderer trail; // The trail renderer component

    void Start()
    {
        trail.enabled = false; // Disable the trail at start
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // Get the horizontal input axis
        float verticalInput = Input.GetAxis("Vertical"); // Get the vertical input axis

        if (horizontalInput != 0f || verticalInput != 0f) // Check for arrow key input
        {
            Vector3 axis = new Vector3(verticalInput, 0f, -horizontalInput).normalized; // Calculate the rotation axis
            transform.RotateAround(cubeTransform.position, axis, speed * Time.deltaTime); // Rotate the ball around the cube
            trail.enabled = true; // Enable the trail while moving
        }
        else
        {
            trail.enabled = false; // Disable the trail when not moving
        }
    }
}
