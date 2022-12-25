using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
   public void Startlvl1() {
        SceneManager.LoadSceneAsync(ScoueIDS.LevelSceneID);
    }


}
