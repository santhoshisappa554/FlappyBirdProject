using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReplayScript : MonoBehaviour
{
   public void GoToNextScene()//redirecting to game scene
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()//redirecting to mainmenu
    {
        SceneManager.LoadScene(2);
    }
}
