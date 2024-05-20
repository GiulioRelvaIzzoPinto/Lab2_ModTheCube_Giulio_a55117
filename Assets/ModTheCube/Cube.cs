using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Material material;
    public float hue;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 3f;
    }
    
    void Update()
    {
        transform.Rotate(100.0f * Time.deltaTime, 0.5f, 0.2f);
        Material material = Renderer.material;
        material.color = Color.HSVToRGB(0.33f, 1.0f, 0.7f);
        CycleColors();
    }

    void CycleColors ()
    {
        hue += Time.deltaTime * 0.1f;
        if (hue > 1.0f) hue = 0.0f;
        Renderer.material.color = Color.HSVToRGB (hue, 1.0f, 1.0f);
    }
}
