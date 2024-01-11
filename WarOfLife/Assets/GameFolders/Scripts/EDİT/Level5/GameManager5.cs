using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager5 : MonoBehaviour
{
    public GameObject gameObject1, gameObject2;
    public string tag1, tag2;
    float time = 0;
    public Sprite whiteIcon;

    public List<GameObject> gameObjects;

    bool full;
    int number = 0;
    void Start()
    {

    }


    void Update()
    {
        PictureControl();
        if (number >= 8)
        {
            SceneManager.LoadScene(6);
        }
    }
    void PictureControl()
    {
        if (gameObject1 != null && gameObject2 != null)
        {
            full = true;
            if (tag1 == tag2)
            {
                gameObject1 = null;
                gameObject2 = null;
                tag1 = "";
                tag2 = "";
                number++;
            }
            else
            {

                time += Time.deltaTime;
                print(time);
                if (time >= 1)
                {
                    gameObject1.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                    gameObject2.GetComponent<Image>().color = new Color(1, 1, 1, 1);
                    gameObject1 = null;
                    gameObject2 = null;
                    tag1 = "";
                    tag2 = "";
                    time = 0;
                }

            }

        }
        else if (gameObject1 == null && gameObject2 == null)
        {
            full = false;
        }
    }
    public void Images(int index)
    {
        if (full == false)
        {

            gameObjects[index].GetComponent<Image>().color = new Color(0, 0, 0, 0);

            if (gameObject1 == null)
            {
                gameObject1 = gameObjects[index];
                tag1 = gameObject1.tag;
            }
            else
            {
                gameObject2 = gameObjects[index];
                tag2 = gameObject2.tag;

            }
        }
    }

}
