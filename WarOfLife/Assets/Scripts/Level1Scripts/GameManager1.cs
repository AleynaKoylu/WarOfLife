using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using WarOfLife;

public class GameManager1 : MonoBehaviour
{
    
    public List<GameObject> Panels = new();
    public GameObject mainCube,targetCube;
    public Button keyButton;
    void FixedUpdate()
    {
        Library.MainCubeRay("MainCube");
    }
    public void AcceptButton()
    {
        Panels[0].SetActive(false);
        Panels[1].SetActive(true);
        mainCube.SetActive(true);
    }
    public void KeyButton()
    {
        targetCube.SetActive(true);
        keyButton.interactable = false;
    }
}
