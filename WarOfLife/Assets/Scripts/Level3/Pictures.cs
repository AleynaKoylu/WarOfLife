using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pictures : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float x = Random.Range(-2, 2);
        float y= Random.Range(7, 8);
        gameObject.transform.position= new Vector3(x,y,0);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            float x = Random.Range(-2, 2);
            float y = Random.Range(7, 8);
            gameObject.transform.position = new Vector3(x, y, 0);
        }
    }
}
