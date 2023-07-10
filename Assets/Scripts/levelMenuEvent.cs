using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelMenuEvent : MonoBehaviour
{
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
        
    }

    public void GoToLevelMenu(int sceneIndex) {
        PlayerPrefs.SetInt("page", 1);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        
    }

    public void GoToHomeMenu(int sceneIndex) {
        PlayerPrefs.SetInt("page", 0);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);
        
    }
}
