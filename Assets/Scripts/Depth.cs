using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Depth : MonoBehaviour
{
    public UnityEngine.UI.Slider DepthSlider; // Drag & drop in inspector
    public Transform Player;
    public float MaxDepth = 72; // Change in inspector
    public float MinDepth = -27; // Change in inspector

    void LateUpdate()
    {
        DepthSlider.value = (Player.position.y - MinDepth) / (MaxDepth - MinDepth);
    }
}