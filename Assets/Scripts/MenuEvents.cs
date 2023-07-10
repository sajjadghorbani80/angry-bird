using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MenuEvents : MonoBehaviour
{
    public Slider VolumeSlider;
    public AudioMixer mixer;
    public void setVolume()
    {
        mixer.SetFloat("volume", VolumeSlider.value);

    }
}
