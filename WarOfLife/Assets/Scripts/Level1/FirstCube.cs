using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstCube : MonoBehaviour
{
    float cameraZDistane;
    bool move;

    void Start()
    {
        cameraZDistane=Camera.main.WorldToScreenPoint(transform.position).z;
    }
    private void OnMouseDrag()
    {
      Vector3 screenPos=new Vector3(Input.mousePosition.x,Input.mousePosition.y,cameraZDistane);
        Vector3 newWorldPos=Camera.main.ScreenToViewportPoint(screenPos)*4f;
        newWorldPos.x = Mathf.Clamp(newWorldPos.x, -2, 2);
        newWorldPos.y = Mathf.Clamp(newWorldPos.y, -2, 4);

        transform.position = newWorldPos;
    }

    
    void Update()
    {
       
    }
}
