using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PicturesLevel5 : MonoBehaviour
{
    public GameObject gameManager;
    GameManager5 gameManager5;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        gameManager5=gameManager.GetComponent<GameManager5>();
        spriteRenderer=GetComponent<SpriteRenderer>();
    }


    private void OnMouseDown()
    {
        if (gameManager5.gameObject1 == null)
        {
            gameManager5.gameObject1 = gameObject;
            gameManager5.tag1 = gameObject.tag;
            spriteRenderer.color = Color.green;
        }
        else
        {
            gameManager5.gameObject2 = gameObject;
            gameManager5.tag2 = gameObject.tag;
            spriteRenderer.color = Color.green;
        }

    }
    void Update()
    {
        
    }
}
