using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeManager : MonoBehaviour
{
    public float masterVolume = 0f;
    public float musicVolume = 0f;
    public float soundVolume = 0f;
    
    public AudioMixer masterMixer;
    public AudioMixer musicMixer;
    public AudioMixer soundMixer;

    public void setMasterVolume (float masterVolume) {
        masterMixer.SetFloat("Master Volume", masterVolume);
    }

    public void setMusicVolume (float musicVolume) {
        masterMixer.SetFloat("Music Volume", musicVolume);
    }

    public void setSoundVolume (float soundVolume) {
        masterMixer.SetFloat("Sound Volume", soundVolume);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
