using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager4 : MonoBehaviour
{

    public int number = 0;

    void Start()
    {

        
    }
    private void Update()
    {
        if (number == 16)
        {
            SceneManager.LoadScene(5);
        }
    }

}
