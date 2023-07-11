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
        if (PlayerPrefs.HasKey("volume"))
        {
            // set the mixer volume levels based on the saved player prefs
            mixer.SetFloat("volume", PlayerPrefs.GetFloat("volume"));
            volumeSlider.value = value;
        }
        // otherwise just set the sliders
        else
        {
            volumeSlider.value = value;
        }
    }
    public void SetVolume()
    {
        mixer.SetFloat("volume", volumeSlider.value);
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
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
