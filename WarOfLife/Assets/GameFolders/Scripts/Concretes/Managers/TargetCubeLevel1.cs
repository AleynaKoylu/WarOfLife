using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife.Concretes.Animations;

namespace WarOfLife.Concretes.Managers
{
    public class TargetCubeLevel1 : MonoBehaviour
    {
        Animator _animator;
        SphereCollider _sphereCollider;
        TargetCubeLevel1Animator _targetCubeLevel1Animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
            _sphereCollider = GetComponent<SphereCollider>();
            _targetCubeLevel1Animator = GetComponent<TargetCubeLevel1Animator>();
        }
        public void AnimatorTrigger()
        {
            _sphereCollider.enabled = true;
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                _targetCubeLevel1Animator.AnimatorEnabled(_animator);
            }
        }

    }
}

