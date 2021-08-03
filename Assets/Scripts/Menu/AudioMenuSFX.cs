using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMenuSFX : MonoBehaviour
{
    public AudioSource SFXAudioSource;
    public static float  SFXs;
    public Slider SliderSFX;
    public AudioClip SFX;
    public static AudioMenuSFX instance;
    void Awake()
    {     
        instance = this;
        DefaultVolume();

    }

    void DefaultVolume()
    {
        SFXs = PlayerPrefs.GetFloat("sfxvolumen", 1.0f);       
        SliderSFX.value = PlayerPrefs.GetFloat("sfxvolumen", 1.0f);
    }

    public void Play(AudioClip audioclip)
    {
        
    }


    public void OnVFXUpdate()
   {
        SFXs = SliderSFX.value;
        PlayerPrefs.SetFloat("sfxvolumen", SliderSFX.value);
        PlayerPrefs.Save();
    }

}
