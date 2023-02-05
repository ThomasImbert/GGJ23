using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuLogic : MonoBehaviour
{

    // public AudioMixer audioMixer;
    public Slider masterVolumeSlider;
    public Slider sfxVolumeSlider;
    public Slider musicVolumeSlider;
    public Slider ambianceVolumeSlider;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        AkSoundEngine.SetRTPCValue("master_Volume_RTPC", masterVolumeSlider.value);
        AkSoundEngine.SetRTPCValue("SFX_Volume_RTPC", sfxVolumeSlider.value);
        AkSoundEngine.SetRTPCValue("Music_Volume_RTPC", musicVolumeSlider.value);
        AkSoundEngine.SetRTPCValue("Ambiance_Volume_RTPC", ambianceVolumeSlider.value);

    }
}
