using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfLife.Concretes.Controllers.GroundControl
{
    public class OnGround : MonoBehaviour
    {
        public bool IsOnGround=>_isOnGround;
        bool _isOnGround = false;
        [SerializeField] List<Transform> transforms;
        [SerializeField] float distance;

        private void Update()
        {
            foreach (Transform t in transforms) 
            {
                CheckTransform(t);
                if (_isOnGround) break;
            }
        }

        private void CheckTransform(Transform t)
        {
            RaycastHit hit;
            

            if (Physics.Raycast(t.position, t.forward, out hit, distance))
            {
                Debug.DrawRay(t.position, t.forward * hit.distance, Color.yellow);
                 _isOnGround = false;
            }
            else
            {
                Debug.DrawRay(t.position, t.TransformDirection(Vector3.forward) * 1000, Color.white);
                _isOnGround = true;
            }
          
            


        }
    }
}

