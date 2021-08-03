using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMenu : MonoBehaviour
{
    public AudioSource SFXAudioSource;
    public AudioSource BGMAudioSource;
    public Slider SliderBGMusic, SliderSFX;
    public AudioClip BGMusic;
    public AudioClip SFX;
    // Start is called before the first frame update
    public static AudioMenu instance;
    void Awake()
    {
        BGMAudioSource.volume = PlayerPrefs.GetFloat("bgmusicvolumen", 1.0f);
        SliderBGMusic.value = BGMAudioSource.volume;
        SFXAudioSource.volume = PlayerPrefs.GetFloat("sfxvolumen", 1.0f);
        SliderSFX.value = SFXAudioSource.volume;
        instance = this;

    }

    void DefaultVolume()
    {
      
      
    }

    void PlayEffect()
    {

    }
    void PlayBGMusic(AudioClip audioclip)
    {
        BGMAudioSource.clip = audioclip;
        BGMAudioSource.Play();
    }

    public void OnBGMusicUpdate()
    {
        
        BGMAudioSource.volume = SliderBGMusic.value;
        PlayerPrefs.SetFloat("bgmusicvolumen", BGMAudioSource.volume);
        PlayerPrefs.Save();
    }
   public void OnVFXUpdate()
   {
        SFXAudioSource.volume = SliderSFX.value;
        PlayerPrefs.SetFloat("sfxvolumen", SFXAudioSource.volume);
        PlayerPrefs.Save();
    }

    void Start()
    {
        BGMAudioSource.volume = PlayerPrefs.GetFloat("bgmusicvolumen", 1.0f);
        SliderBGMusic.value = BGMAudioSource.volume;
        SFXAudioSource.volume = PlayerPrefs.GetFloat("sfxvolumen", 1.0f);
        SliderSFX.value = SFXAudioSource.volume;
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    
    }
}
