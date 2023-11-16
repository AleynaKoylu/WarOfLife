using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour
{
    
    void Start()
    {
        
    }
    void FixedUpdate()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 100))
        {
            if (hit.collider.CompareTag("MainCube"))
            {
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
                hit.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
            }
        }
           
    }
    
    void Update()
    {
       
    }
}
