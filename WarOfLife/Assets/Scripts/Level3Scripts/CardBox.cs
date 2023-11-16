using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife;
public class CardBox : MonoBehaviour
{
  
    public float targetDownSpeed=2;
    int cubeIndex=0;
    void Start()
    {
        
    }

    
    void Update()
    {
        Library.VectorsClamp(gameObject, -2, -2.52f,2, -2.52f);
        if (cubeIndex > 15)
        {
            print("bitti");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Cubes"))
        {
            other.gameObject.SetActive(false);
            cubeIndex++;
            print("Degdi");
           
        }
    }

}
