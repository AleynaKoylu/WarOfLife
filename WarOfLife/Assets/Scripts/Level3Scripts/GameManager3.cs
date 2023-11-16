using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife;
public class GameManager3 : MonoBehaviour
{
    public List<GameObject> Photos = new List<GameObject>();

    int cube = 0;
    void Start()
    {
        StartCoroutine(CubesMovement());
    }


    void Update()
    {
        Library.MainCubeRay("MainCube");
    }

    IEnumerator CubesMovement()
    {
        while (cube < 16)
        {
            if (cube == 0)
            {
                cube += 1;
            }

            else
            {
                yield return new WaitForSeconds(1f);
                Photos[cube].SetActive(true);
                cube++;
            }

        }





    }
}
