using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerLevel1 : MonoBehaviour
{
    public GameObject TargetPos;
    public Button �nfoBtn;
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }
    public void InfoButton()
    {
        TargetPos.GetComponent<Animator>().enabled=true;
        �nfoBtn.interactable=false;
    }
}
