using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    public Camera cam1, cam2;

    void Start()
    {
        cam2.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
    }

    void Update()
    {
        
    }
}
