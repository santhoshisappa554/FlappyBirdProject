using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WelcomeScript : MonoBehaviour
{
    public void GotoMenuScene()//Redirecting to main menu scene
    {
        SceneManager.LoadScene(2);
    }
}
