using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class PauseManager : MonoBehaviour
    {
        [SerializeField] private GameObject pauseWindow;
        [SerializeField] private Animator pauseAnimator;
        [SerializeField] private KeyCode pauseKey = KeyCode.Escape;

        private bool isOpen;
        private bool canPause;
        private bool isPaused;
        
        public void Awake()
        {
            isOpen = false;
            canPause = true;
        }

        private void Update()
        {
            if (Input.GetKeyDown(pauseKey))
            {
                Pause();
            }
        }

        public void Pause()
        {
            isOpen = !isOpen;
            if (canPause)
            {
                StartCoroutine(PauseFunction());
            }
        }
        
        public void MainMenuButton(int i = 0)
        {
            SceneManager.LoadScene(i);
        }

        public void RestartButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("Reinicia el nivel");
        }

        private IEnumerator PauseFunction()
        {
            canPause = false;
            pauseAnimator?.SetBool("Active", true);

            yield return new WaitForSeconds(1.6f);
            
            Time.timeScale = 1f;
            
            yield return new WaitWhile(() => isOpen);
            
            Time.timeScale = 1f;
            pauseAnimator?.SetBool("Active", false);

            yield return new WaitForSeconds(1.6f);
            
            canPause = true;
        }
    }
}