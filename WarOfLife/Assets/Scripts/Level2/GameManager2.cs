using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public GameObject mainCube;

    
    void Start()
    {
     
    }

    void Update()
    {
      
    }
  
    public void DirectionBtnControl(string name)
    {
        if(name=="Right") 
        { 
            if(mainCube.transform.position.x<2f)
            mainCube.transform.position = new Vector3(mainCube.transform.position.x+.1f,mainCube.transform.position.y,mainCube.transform.position.z);
            
        }
        if (name == "Left")
        {
            if (mainCube.transform.position.x > -2)
                mainCube.transform.position = new Vector3(mainCube.transform.position.x - .1f, mainCube.transform.position.y, mainCube.transform.position.z);
        
        }
        if (name == "Up")
        {
            if (mainCube.transform.position.y <= 4)
                mainCube.transform.position = new Vector3(mainCube.transform.position.x , mainCube.transform.position.y + .1f, mainCube.transform.position.z);
          
        }
        if (name == "Down")
        {
            if (mainCube.transform.position.y > -2)
                mainCube.transform.position = new Vector3(mainCube.transform.position.x, mainCube.transform.position.y - .1f, mainCube.transform.position.z);
           
        }
    }
}
