using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WarOfLife.Concretes.Controllers.SceneController
{
    public class SceneController : MonoBehaviour
    {
        public void SceneChange(int sceneIndex)
        {
            SceneManager.LoadScene(sceneIndex); 
        }
    }
}

