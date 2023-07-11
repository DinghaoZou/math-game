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

    public void setMasterVolume (float masterVolume) {
        masterMixer.SetFloat("Master Volume", masterVolume);
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
