using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class MainMenuManager : MonoBehaviour
{
    public List<GameObject> Panels = new();
    public List<Text> Texts = new ();
    public InputField ýnputField;

    void Start()
    {
       print(PlayerPrefs.GetString("Name"));
    }
    public void ButtonsMethod(int index)
    {
        switch (index)
        {
            case 0:
                if (PlayerPrefs.GetString("Name") != "")
                    SceneManager.LoadScene(1);
                else
                    Panels[2].SetActive(true);
                break;
            case 1:
                Application.Quit();
                break;
            case 2:
                print(Texts[7].text);
                ýnputField.interactable = false;
                PlayerPrefs.SetString("Name", Texts[7].text);
                SceneManager.LoadScene(1);
                break;
           
        }
    }
}
