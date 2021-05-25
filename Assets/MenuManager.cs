using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    //initializing gameobjects
    public GameObject OptionPanel;
    public GameObject HelpPanel;
    public GameObject TopPanel, BottomPanel;
    // Start is called before the first frame update
    public void Optionmenu()//Redirects to OptionPanel
    {
        OptionPanel.SetActive(true);
        TopPanel.SetActive(false);
        BottomPanel.SetActive(false);
        HelpPanel.SetActive(false);
    }
    public void Back()//Redirects to mainmenu
    {
        TopPanel.SetActive(true);
        BottomPanel.SetActive(true);
        OptionPanel.SetActive(false);
        HelpPanel.SetActive(false);
        

    }
    public void Helpmenu()//Redirects to HelpPanel
    {
        HelpPanel.SetActive(true);
        TopPanel.SetActive(false);
        BottomPanel.SetActive(false);
        OptionPanel.SetActive(false);
    }
    public void HelpBack()//Redirects to MainMenu
    {

        TopPanel.SetActive(true);
        BottomPanel.SetActive(true);
        HelpPanel.SetActive(false);
        OptionPanel.SetActive(false);
    }

}
