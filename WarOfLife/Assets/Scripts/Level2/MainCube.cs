using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainCube : MonoBehaviour
{
    public Text wrongText;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obs"))
        {
            SceneManager.LoadScene(1);
        }
        if (other.gameObject.CompareTag("Warn"))
        {
            wrongText.gameObject.SetActive(true);
        }
        if (other.gameObject.CompareTag("True"))
        {
            SceneManager.LoadScene(3);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Warn"))
        {
            wrongText.gameObject.SetActive(false);
        }
    }
}
