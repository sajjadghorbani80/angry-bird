using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class levelMenuEvent : MonoBehaviour
{

    public Slider volumeSlider;
    public AudioMixer mixer;
    private float value;
    private void Start()
    {
        mixer.GetFloat("volume", out value);
        volumeSlider.value = value;
    }
    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
    }
    public void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);

    }

    public void GoToLevelMenu(int sceneIndex)
    {
        PlayerPrefs.SetInt("page", 1);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);

    }

    public void GoToHomeMenu(int sceneIndex)
    {
        PlayerPrefs.SetInt("page", 0);
        SceneManager.LoadScene(sceneIndex, LoadSceneMode.Single);

    }
}
