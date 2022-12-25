using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenManager : MonoBehaviour
{
   public void CloseGame()
    {
        
        Application.Quit();
    }

   public void ReplayLevel()
    {
        SceneManager.LoadSceneAsync(ScoueIDS.LevelSceneID);
    }
}
