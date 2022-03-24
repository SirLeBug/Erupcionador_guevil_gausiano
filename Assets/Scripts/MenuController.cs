using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuController : MonoBehaviour
{
    [Header("Volume Setting")]
    [SerializeField] private TextMeshProUGUI volumeTextValue = null;
    [SerializeField] private Slider volumeSlider = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        volume = volume * 100;
        volumeTextValue.text = volume.ToString("0");
    }

    public void VolumeApplyMaster()
    {
        PlayerPrefs.SetFloat("masterVolume", AudioListener.volume);
    }
    
    public void VolumeApplyMusic()
    {
        PlayerPrefs.SetFloat("musicVolume", AudioListener.volume);
    }
    public void VolumeApplyEffects()
    {
        PlayerPrefs.SetFloat("effectsVolume", AudioListener.volume);
    }
}
