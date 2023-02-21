using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    public Renderer ballRenderer;

    void OnMouseDown()
    {
        Color randomColor = Random.ColorHSV(); // Generate a random color
        cubeRenderer.material.color = randomColor; // Change the color of the cube
        ballRenderer.material.color = randomColor; // Change the color of the ball
    }
}
