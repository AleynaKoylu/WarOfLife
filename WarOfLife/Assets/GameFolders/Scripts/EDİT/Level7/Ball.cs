using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Animations;
using UnityEngine;

public class Ball : MonoBehaviour
{


    public Vector3 firstPos;
    public Vector3 lastPos;
    public float angleY;

    private void Update()
    {
        transform.position += transform.right * Time.deltaTime;
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + .1f, transform.position.z);
        }
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            firstPos = Camera.main.ScreenToWorldPoint(pos);

        }
        if (Input.GetMouseButton(0))
        {

            Vector3 pos = Input.mousePosition;
            pos.z = 10;
            lastPos = Camera.main.ScreenToWorldPoint(pos);
            angleY += firstPos.x - lastPos.x;
            transform.rotation = Quaternion.Euler(0, angleY * 200, 0);
          
            print(angleY);
            firstPos = lastPos;


        }
    }
    /* void Start()
     {


     }


     void Update()
     {

         // transform.position+=transform.right*Time.deltaTime;


         if (Input.GetKey(KeyCode.A))
         {
             transform.position = new Vector3(transform.position.x, transform.position.y + .1f, transform.position.z);
         }
         if (Input.GetMouseButtonDown(0))
         {
             First();
         }
         if (Input.GetMouseButton(0))
         {
             Move();
         }
     }
     public void Move()
     {

         Vector3 pos = Input.mousePosition;
         pos.z = 0;
         lastPos = Camera.main.ScreenToWorldPoint(pos);
         Vector3 dif = lastPos - firstPos;
         transform.position = dif * Time.deltaTime * 500f;
         transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), Mathf.Clamp(transform.position.y, -3, 4), transform.position.z);
         firstPos = lastPos;

     }
     public void First()
     {

         Vector3 pos = Input.mousePosition;
         pos.z = 0;
         firstPos = Camera.main.ScreenToWorldPoint(pos);
     }*/





}