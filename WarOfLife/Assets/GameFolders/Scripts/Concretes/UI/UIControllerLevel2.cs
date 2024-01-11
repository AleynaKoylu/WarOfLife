using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfLife.Concretes.UI
{
    public class UIControllerLevel2 : MonoBehaviour
    {
        [SerializeField] GameObject mainPanel;
        bool _startGame;
        public bool StartGame=> _startGame;

        public void StartGameClick()
        {
            _startGame = true;
            mainPanel.SetActive(false);
        }
    }
}

