using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using WarOfLife.Concretes.Controllers.GroundControl;

namespace WarOfLife.Concretes.Managers
{
    public class MainCubeLevel2 : MonoBehaviour
    {
        public bool IsLose => _onGround.IsOnGround;
        public bool IsOnWrong => _isOnWrong;
        public bool IsOnTrue => _isOnTrue;
        bool _isOnWrong;
        bool _isOnTrue;
        OnGround _onGround;
        private void Awake()
        {
            _onGround=GetComponent<OnGround>();
        }
        private void OnMouseDrag()
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), Mathf.Clamp(transform.position.y, -2, 4), transform.position.z);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("True"))
            {
                _isOnTrue = true;
            }
            if (other.gameObject.CompareTag("Warn"))
            {
                _isOnWrong = true;
            }
        }
         void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Warn"))
            {
                _isOnWrong =false;
            }
        }
    }
}

