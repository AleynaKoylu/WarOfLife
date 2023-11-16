using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WarOfLife;
public class MainCube : MonoBehaviour
{
    
    void Update()
    {
        Library.VectorsClamp(gameObject, -2, -3, 2, 4);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.transform.CompareTag("TargetCube"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
