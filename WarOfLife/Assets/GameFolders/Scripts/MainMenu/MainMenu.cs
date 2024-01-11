using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text Text;
    public List<string> texts = new List<string>();
    public List<Button> letterButtons = new List<Button>();
    public List< Button> mainButtons=new List<Button>();
    int textID;
    public List<Image> panels= new List<Image>();
    void Start()
    {
        if (textID == 0)
        {
            mainButtons[0].interactable = false;
        }
    }


    void Update()
    {
       
        if (textID == 4)
        {
            foreach (Button button in letterButtons)
            {
                button.interactable = false;
            }
            mainButtons[1].interactable = true;
        }
        else if (textID < 4)
        {
            foreach (Button button in letterButtons)
            {
                button.interactable = true;
            }
            mainButtons[1].interactable = false;
        }
        if (textID >0)
        {

            mainButtons[0].interactable = true;
            
        }

    }
    public void TextName(string c)
    {
        Text.text = Text.text + c;
        texts.Add(c);
        textID++;
       
    }
    public void DeleteC()
    {
        texts.RemoveAt(textID - 1);
        textID--;
        if (textID == 0)
        {
            mainButtons[0].interactable = false;
        }
        else
        {
            mainButtons[0].interactable = true;
        }
        switch (textID)
        {
            case 0:
                Text.text = "";
                break;
            case 1:
                Text.text = texts[0];
                break;
            case 2:
                Text.text = texts[0] + texts[1];
                break;
            case 3:
                Text.text = texts[0] + texts[1] + texts[2];
                break;
        }

    }
    public void Buttons(string name)
    {
        switch (name)
        {
            case "Start":
                panels[0].gameObject.SetActive(false);
                panels[1].gameObject.SetActive(true);
                break;
            case "Exit":
                Application.Quit();
                break;
            case "Save":
                SceneManager.LoadScene(1);
                break;
        }
    }
  
}
