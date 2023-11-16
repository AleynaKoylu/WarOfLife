using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainMenuManager : MonoBehaviour
{
    public List<GameObject> Panels = new List<GameObject>();
    public List<Text> Texts = new List<Text>();
    public InputField ýnputField;

    void Start()
    {
       print(PlayerPrefs.GetString("Name"));
    }


    void Update()
    {

    }

    public void ButtonsMethod(int index)
    {
        switch (index)
        {
            case 0:
                if (PlayerPrefs.GetString("Name") != "")
                    print("AA");
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
                break;
           
        }
    }
}
