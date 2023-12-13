using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    public List<GameObject> Pictures = new List<GameObject>();
    int pictureNumber;
    int number =0;
    void Start()
    {
        //pictureNumber = Random.Range(0, Pictures.Count);
        // StartCoroutine(PicturesActive());
        InvokeRepeating("PicturesActive", .5f, 2f);
    }


    void Update()
    {
       
       /* for (int i = 0; i < Pictures.Count; i++)
        {
            if (Pictures[pictureNumber].activeSelf == false)
            {
                Pictures[pictureNumber].SetActive(true);
               
                number++;
                if (number == 1)
                {
                    number = 0;
                    break;
                }
            }
          
        }*/
          


    }

    void PicturesActive()
    {

        if (Pictures.Count > 0)
        {

            if (Pictures[pictureNumber].activeSelf == false)
            {
                Pictures[pictureNumber].SetActive(true);
                Pictures.RemoveAt(pictureNumber);

                pictureNumber = Random.Range(0, Pictures.Count);
            }
            else
            {
                pictureNumber = Random.Range(0, Pictures.Count);
            }




        }
       
    }
}
