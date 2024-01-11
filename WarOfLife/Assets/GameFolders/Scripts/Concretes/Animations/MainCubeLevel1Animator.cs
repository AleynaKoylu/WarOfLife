using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfLife.Concretes.Animations
{
    public class MainCubeLevel1Animator : MonoBehaviour
    {
        bool _animationFinish=false;
        public bool AnimatorFinish=> _animationFinish;
       
        public void AnimatorEnabled()
        {
            _animationFinish = true;
        }
    }
}

