using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject ball;
    public float camSpeed;
    void Start() 
    {
        
    }

    

    
    void Update()
    {
        transform.position = Vector3.Slerp(transform.position, new Vector3(ball.transform.position.x-10,transform.position.y, ball.transform.position.z),camSpeed);
        transform.rotation= Quaternion.Euler(40,ball.transform.rotation.y+90,transform.rotation.z);
        
      
    }
}
