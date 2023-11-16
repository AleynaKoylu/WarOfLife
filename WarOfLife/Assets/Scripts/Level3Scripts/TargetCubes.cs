using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCubes : MonoBehaviour
{
    CardBox cardBox = new CardBox();
    float downSpeed;
    private void Start()
    {
        float randomX = Random.Range(-1.5f, 1.5f);
        gameObject.transform.position = new Vector3(randomX, transform.position.y, 0);
        downSpeed = cardBox.targetDownSpeed;
    }
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime *downSpeed);
        print(downSpeed);
    }
 
}

        