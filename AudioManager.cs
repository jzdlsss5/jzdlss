
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;    // 进行控制的Mixer变量
    public void SetMasterVolume(float volume)    // 控制主音量的函数
    {
        audioMixer.SetFloat("MasterVolume", volume);
    }
    public void SetMusicVolume(float volume)    
    {
        audioMixer.SetFloat("Music", volume);
    }
    public void SetSoundEffectVolume(float volume)   
    bghfgdgh
}
