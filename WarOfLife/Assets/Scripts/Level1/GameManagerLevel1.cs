using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerLevel1 : MonoBehaviour
{
    public GameObject TargetPos;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    public void InfoButton()
    {
        TargetPos.GetComponent<Animator>().enabled=true;
    }
}
