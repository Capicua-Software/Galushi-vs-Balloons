using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioMag : MonoBehaviour
{
    public AudioMixer mixer;

    public void VolumeBGMusic(float slidervalue)
    {
        mixer.SetFloat("MusicVol", Mathf.Log10( slidervalue) * 20);
    }
   
}
