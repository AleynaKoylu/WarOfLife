using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife.Concretes.Animations;
using WarOfLife.Concretes.Controllers.MoveController;


namespace WarOfLife.Concretes.Managers
{

    public class MainCubeLevel1 : MonoBehaviour
    {
        public bool Target => _target;
        bool _target = false;
        MainCubeLevel1Animator _mainCubeLevel1Animator;
        Animator _animator;
        MouseInput _mouseInput;
        private void Awake()
        {
            _animator=GetComponentInChildren<Animator>();
            _mainCubeLevel1Animator=GetComponentInChildren<MainCubeLevel1Animator>();
            _mouseInput=GetComponent<MouseInput>();
        }
        private void Update()
        {
            _target = _mainCubeLevel1Animator.AnimatorFinish;
        }
        void OnMouseDrag()
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2, 2), Mathf.Clamp(transform.position.y, -2, 4), transform.position.z);
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("TargetCube"))
            {
                _animator.enabled = true;
                _mouseInput.Speed = 0;
            }
        }
    }

}
