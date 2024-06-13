using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumeSlider;

    void Start()
    {
        // Pone el valor del volumen al que está inicialmente
        float volume;
        audioMixer.GetFloat("volume", out volume);
        volumeSlider.value = Mathf.Pow(10, volume / 20);

        // Add listener for slider value change
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        // Convert slider value to logarithmic scale
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }
}
