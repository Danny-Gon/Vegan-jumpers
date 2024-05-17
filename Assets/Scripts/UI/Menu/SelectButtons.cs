using System;
using System.Collections;
using System.Collections.Generic;
using Managers.Activables;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Menu
{
    public class SelectButtons : MonoBehaviour
    {
        [SerializeField] private GameObject settingsWindow;
        [SerializeField] private Animator settingsAnimator;
        

        private bool isOpen;
        private bool canActivate;

        private void Awake()
        {
            canActivate = true;
            isOpen = false;
        }

        public void PlayButton(int i = 1)
        {
            SceneManager.LoadScene(i);
        }

        public void SettingsButton()
        {
            isOpen = !isOpen;
            if (canActivate)
            {
                StartCoroutine((SettingsFunction()));
            }
        }
        
        public void MainMenuButton(int i = 0)
        {
            SceneManager.LoadScene(i);
        }
        
        public void QuitButton()
        {
            Debug.Log("Saliste de la aplicacion");
            Application.Quit();
        }

        public void GoBackButton()
        {
            isOpen = !isOpen;
        }

        private IEnumerator SettingsFunction()
        {
            canActivate = false;
            
            settingsAnimator.SetTrigger("Active");
            
            yield return new WaitWhile(() => isOpen);
            
            settingsAnimator.SetBool("Active", false);

            yield return new WaitForSeconds(1.6f);
            
            canActivate = true;
        }
        
    }
    
}