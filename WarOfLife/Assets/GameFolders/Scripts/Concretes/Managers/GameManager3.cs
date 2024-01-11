using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using WarOfLife.Concretes.Controllers.SceneController;

namespace WarOfLife.Concretes.Managers
{
    public class GameManager3 : MonoBehaviour
    {
        public int PictureNumber { get { return _pictureNumber; } set { _pictureNumber = value; } }
        int _pictureNumber;
        [SerializeField] List<GameObject> pictures;
        bool _pictureActive;
        public bool Wrong { get { return _wrong; } set { _wrong = value; } }
        bool _wrong;
        SceneController _sceneController;
        private void Awake()
        {
             _sceneController = GetComponent<SceneController>();
        }
        private void Start()
        {
            InvokeRepeating("Pictures", .5f, 1.5f);
        }
        private void Update()
        {
            PicturesActive();
            SceneControl();
        }
       
        void PicturesActive()
        {
            if (_pictureNumber < pictures.Count)
            {
                _pictureActive = true;
            }
            else
            {
                _pictureActive = false;
            }
        }
        void Pictures()
        {
            if (_pictureActive)
            {
                int pictureNumber = Random.Range(0, pictures.Count);
                if (pictures[pictureNumber].activeSelf)
                {
                    pictures[pictureNumber].GetComponent<PicturesLevel3>().ActiveMove = true;
                }
                else
                {

                    Pictures();
                }
            }
            
        }
        void SceneControl()
        {
            if (_wrong)
            {
                _sceneController.SceneChange(0);
            }
            if (_pictureNumber == pictures.Count)
            {
                _sceneController.SceneChange(4);
            }
        }
       
    }
}

