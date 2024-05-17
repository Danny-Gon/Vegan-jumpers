
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Menu
{
    public class VolumeSettings : MonoBehaviour
    {
        [SerializeField] private AudioMixer mixerSettings;
        [SerializeField] private Slider masterSlider;
        [SerializeField] private Slider musicSlider;
        [SerializeField] private Slider fxSlider;

        private void Start()
        {
            if (PlayerPrefs.HasKey("musicVolume"))
            {
                LoadVolume();
            }if (PlayerPrefs.HasKey("sfxVolume"))
            {
                LoadVolume();
            }else if (PlayerPrefs.HasKey("masterVolume"))
            {
                LoadVolume();
            }
            else
            {
                SetMusicVolume();
                SetSfxVolume();
            }
        }

        public void SetMusicVolume()
        {
            float volumeMusic = musicSlider.value ;
            mixerSettings.SetFloat("musicLumens", Mathf.Log10(volumeMusic) * 20);
            PlayerPrefs.SetFloat("musicVolume" , volumeMusic);
            
        }

        public void SetSfxVolume()
        {
            float volumeSfx = fxSlider.value;
            mixerSettings.SetFloat("sfxLumens", Mathf.Log10(volumeSfx) * 20);
            PlayerPrefs.SetFloat("sfxVolume" , volumeSfx);
        }

        public void SetMasterVolume()
        {
            float volumeMaster = masterSlider.value;
            mixerSettings.SetFloat("MasterLumens", Mathf.Log10(volumeMaster) * 20);
            PlayerPrefs.SetFloat("masterVolume" , volumeMaster);
        }

        private void LoadVolume()
        {
            musicSlider.value = PlayerPrefs.GetFloat("musicVolume");
            fxSlider.value = PlayerPrefs.GetFloat("sfxVolume");
            masterSlider.value = PlayerPrefs.GetFloat("masterVolume");
            
            
            SetMusicVolume();
        }
    }
}