using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WarOfLife.Concretes.Managers
{
    public class PicturesLevel3 : MonoBehaviour
    {
        public  bool ActiveMove { get {return _activeMove; }set { _activeMove = value; } }
        bool _activeMove;
        Rigidbody _rigidbody;
        [SerializeField] GameManager3 gameManager3;
        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }
        private void Update()
        {
           _rigidbody.useGravity = _activeMove;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Warn"))
            {
                gameManager3.Wrong = true;
            }
        }



    }

}
