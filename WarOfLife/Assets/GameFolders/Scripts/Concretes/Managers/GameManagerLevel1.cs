using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WarOfLife.Concretes.Controllers.SceneController;
using WarOfLife.Concretes.UI;

namespace WarOfLife.Concretes.Managers
{
    public class GameManagerLevel1 : MonoBehaviour
    {
        [SerializeField] UIControllerLevel1 uIControllerLevel1;
        [SerializeField] GameObject mainCube;
        [SerializeField] GameObject targetCube;
        MainCubeLevel1 _mainCubeLevel1;
        SceneController _sceneController;

        private void Awake()
        {
            _sceneController = GetComponent<SceneController>();
            _mainCubeLevel1 = mainCube.GetComponent<MainCubeLevel1>();
        }
        private void Update()
        {
            ChangeScene();
            OpenGame();
        }

        void OpenGame()
        {
            mainCube.SetActive(uIControllerLevel1.MainPanelFalse);
            targetCube.SetActive(uIControllerLevel1.TargetCube);
        }
        void ChangeScene()
        {
            if (_mainCubeLevel1.Target)
            {
                _sceneController.SceneChange(2);
            }

        }
    }
}

