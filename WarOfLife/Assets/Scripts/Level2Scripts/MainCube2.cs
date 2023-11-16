using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife;
using UnityEngine.SceneManagement;
public class MainCube2 : MonoBehaviour
{
   
    public GameObject panelWrong;
    /*void Start()
    {
        
    }*/

   
    void Update()
    {
        Library.VectorsClamp(gameObject, -2.210f, -2.517644f, 1.369275f, 4);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SceneManager.LoadScene(1);
        }
        else if (other.gameObject.CompareTag("WrongCube"))
            panelWrong.SetActive(true);
        else if (other.gameObject.CompareTag("TargetCube"))
            SceneManager.LoadScene(3);
    }
}
