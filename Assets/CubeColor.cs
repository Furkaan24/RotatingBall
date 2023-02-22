using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColor : MonoBehaviour
{
    public Renderer cubeRenderer;
    public Renderer ballRenderer;

    void OnMouseDown()
    {
        Color randomColor = Random.ColorHSV(); 
        cubeRenderer.material.color = randomColor; 
        ballRenderer.material.color = randomColor;
    }
}
