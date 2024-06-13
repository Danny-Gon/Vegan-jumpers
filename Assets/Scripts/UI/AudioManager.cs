using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;
    public Image imagenMute;

    private void Start()
    {
        SetMusicVolume();
    }
    public void SetMusicVolume()
    {
        float volume = volumeSlider.value;
        audioMixer.SetFloat("music", Mathf.Log10(volume)*20);

        /*if (volumeSlider.value == 0)
        {
            imagenMute.SetActive(true);
        }
        else
        {
            imagenMute.SetActive(false);
        }*/
        

    }
}
