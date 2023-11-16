using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WarOfLife
{
    public static class Library
    {
        public static void MainCubeRay(string Tag)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.CompareTag(Tag))
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10f));
                    hit.transform.position = new Vector3(mousePos.x, mousePos.y, 0);
                    
                }
            }
        }
        public static void VectorsClamp(GameObject gameobject,float xMin, float yMin, float xMax,float yMax)
        {
            float x = Mathf.Clamp(gameobject.transform.position.x, xMin, xMax);
            float y = Mathf.Clamp(gameobject.transform.position.y, yMin, yMax);
            gameobject.transform.position = new Vector3(x, y, 0);
            
        }
    }
}

