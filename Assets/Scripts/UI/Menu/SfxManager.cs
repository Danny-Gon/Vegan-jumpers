using UnityEngine;

namespace Managers
{
    public class SfxManager : MonoBehaviour
    {
        public static SfxManager Instance;

        [SerializeField] private AudioSource soundFxDoor;
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
            } 
        }

        public void PlaySoundClip(AudioClip audioclip, Transform spawnTransform, float clipVolume)
        {
            //spawn game object
            AudioSource audioSource = Instantiate(soundFxDoor, spawnTransform.position, Quaternion.identity);
            //assign audio clip
            audioSource.clip = audioclip;
            //assign volume
            audioSource.volume = clipVolume;
            //play sound
            audioSource.Play();

            float clipLength = audioSource.clip.length;
            
            //Destroy game object
            Destroy(audioSource.gameObject, clipLength);
        }

    }
}
