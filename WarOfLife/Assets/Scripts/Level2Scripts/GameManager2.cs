using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife;
public class GameManager2 : MonoBehaviour
{
   
    public List<GameObject> Panels;
    bool MainPanelActive = true;
    public GameObject findTxt;
    void Start()
    {
        StartCoroutine(MainPanelTime());

        StartCoroutine(TextPanelTime());
    }
    private void FixedUpdate()
    {
        if (MainPanelActive == false)
            Library.MainCubeRay("MainCube");
    }
    IEnumerator MainPanelTime()
    {
        yield return new WaitForSeconds(3);
        Panels[0].SetActive(false);
        Panels[1].SetActive(true);
        MainPanelActive = false;
    }
    IEnumerator TextPanelTime()
    {
        while (true)
        {
            yield return null;
            if (findTxt.activeSelf||Panels[2].activeSelf)
            {
                yield return new WaitForSeconds(2);
                findTxt.SetActive(false);
                Panels[2].SetActive(false);
            }
        }



    }
    public void GoTextActive()
    {
        findTxt.SetActive(true);
    }
   
}
