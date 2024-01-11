using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife.Concretes.Controllers.SceneController;
using WarOfLife.Concretes.UI;

namespace WarOfLife.Concretes.Managers
{
    public class GameManager2 : MonoBehaviour
    { 
        [SerializeField] GameObject wrongText;
        [SerializeField] UIControllerLevel2 uIControllerLevel2;
        [SerializeField] GameObject mainCube;
        MainCubeLevel2 mainCubeLevel2;
        SceneController _sceneController;
        BoxCollider _mainCubeBoxCollider;
        private void Awake()
        {
            mainCubeLevel2=mainCube.GetComponent<MainCubeLevel2>();
            _sceneController = GetComponent<SceneController>();
            _mainCubeBoxCollider = mainCube.GetComponent<BoxCollider>();
        }


        void Update()
        {
            OpenText();
            ChangeScene();
            StartGame();
        }

        void OpenText()
        {
            wrongText.SetActive(mainCubeLevel2.IsOnWrong);
        }
        void ChangeScene()
        {
            if (mainCubeLevel2.IsOnTrue)
            {
                _sceneController.SceneChange(3);
            }
            if (mainCubeLevel2.IsLose)
            {
                _sceneController.SceneChange(0);
            }
        }
        void StartGame()
        {
            _mainCubeBoxCollider.enabled = uIControllerLevel2.StartGame;
        }

    }
}

