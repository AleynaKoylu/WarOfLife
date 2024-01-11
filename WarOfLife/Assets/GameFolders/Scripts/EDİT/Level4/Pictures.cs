using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pictures : MonoBehaviour
{
    float x;
    float y;
    public string tagg;
    public Vector3 firstPos;
    public Vector3 lastPos;
    public GameObject gameManger;
    GameManager4 gameManager4;
    void Start()
    {
        x = Random.Range(-1.8f, 1.9f);
        y = Random.Range(.7f, 2);
        transform.localPosition = new Vector3(x, y, 0);
        gameManager4=gameManger.GetComponent<GameManager4>();

    }
    private void OnMouseDrag()
    {
        Vector3 pos = Input.mousePosition;
        pos.z = 0;
        lastPos = Camera.main.ScreenToWorldPoint(pos);
        Vector3 dif = lastPos - firstPos;
        transform.localPosition += dif * Time.deltaTime * 100f;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), Mathf.Clamp(transform.position.y, -3, 4), transform.position.z);
        firstPos = lastPos;


    }
    private void OnMouseDown()
    {

        Vector3 pos = Input.mousePosition;
        pos.z = 0;
        firstPos = Camera.main.ScreenToWorldPoint(pos);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(tagg))
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = Color.white;
            gameManager4.number++;
            print(gameManager4.number);
            gameObject.SetActive(false);
        }

    }

}

