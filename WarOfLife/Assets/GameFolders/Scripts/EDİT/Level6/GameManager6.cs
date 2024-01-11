using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager6 : MonoBehaviour
{
    public string tag;
    float time = 0;
    public Sprite whiteIcon;

    public List<GameObject> gameObjects=new List<GameObject>();

    bool full;
    int number = 0;
    void Start()
    {

    }


    void Update()
    {
        PictureControl();
        
    }
    void PictureControl()
    {
      
    }
    public void Images(int index)
    {
       

            gameObjects[index].GetComponent<Image>().color = new Color(0, 0, 0, 0);
        if (gameObjects[index].CompareTag("0"))
            print("False");
        else if (gameObjects[index].CompareTag("1"))
            print("True");
        
    }
}
