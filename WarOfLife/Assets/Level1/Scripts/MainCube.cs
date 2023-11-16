using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCube : MonoBehaviour
{
 
    void Start()
    {
        
    }

    void Update()
    {
        float x = Mathf.Clamp(gameObject.transform.position.x, -2, 2);
        float y = Mathf.Clamp(gameObject.transform.position.y, -3, 4);
        gameObject.transform.position = new Vector3(x, y, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("TargetCube"))
        {
            print("Kazandýn");
        }
    }
}
