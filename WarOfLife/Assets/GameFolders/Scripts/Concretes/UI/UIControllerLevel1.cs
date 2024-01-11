using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WarOfLife.Concretes.UI
{
    public class UIControllerLevel1 : MonoBehaviour
    {
        [SerializeField] GameObject firstPanel;
        [SerializeField] GameObject infoButton;
        bool _mainPanelFalse=false;
        public bool TargetCube => _targetCube;
        bool _targetCube;
        public bool MainPanelFalse=>_mainPanelFalse;
        public void MainPanelActiveFalse()
        {
            _mainPanelFalse = true;
            firstPanel.SetActive(false);
            infoButton.SetActive(true);
        }
        public void InfoButton()
        {
            _targetCube = true;
            infoButton.SetActive(!_targetCube);
        }
    }
}

