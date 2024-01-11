using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace WarOfLife.Concretes.Controllers.MoveController
{
    public class MouseInput :MonoBehaviour
    {
        public float Speed { get { return _speed; } set { _speed = value; } }
        Vector3 _firstPos,_lastPos;
        [SerializeField]float _speed;
        private void OnMouseDown()
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 0;
            _firstPos = Camera.main.ScreenToWorldPoint(pos);
        }
        private void OnMouseDrag()
        {
            Vector3 pos = Input.mousePosition;
            pos.z = 0;
            _lastPos = Camera.main.ScreenToWorldPoint(pos);
            Vector3 dif = _lastPos - _firstPos;
            transform.localPosition += dif * _speed * Time.deltaTime;
            _firstPos = _lastPos;
        }
    }
}

