using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioMenuBGMUSIC : MonoBehaviour
{

    public AudioSource BGMAudioSource;   
    public Slider SliderBGMusic;
    public AudioClip BGMusic;    
    public static AudioMenuBGMUSIC instance;

    void Awake()
    {
       
        instance = this;
        DefaultVolume();
    }

    void DefaultVolume()
    {
        BGMAudioSource.volume = PlayerPrefs.GetFloat("bgmusicvolumen", 1.0f);
        SliderBGMusic.value = BGMAudioSource.volume;
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
   

}
