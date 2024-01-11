using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfLife.Concretes.Managers
{
    public class BoxLevel3 : MonoBehaviour
    {
        [SerializeField] GameManager3 gameManager3;

        private void OnMouseDrag()
        {
            transform.position=new Vector3(Mathf.Clamp(transform.position.x,-2,2),-2.5f,0);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                
                gameManager3.PictureNumber++;
                other.gameObject.SetActive(false);
            }
        }
    }

}
