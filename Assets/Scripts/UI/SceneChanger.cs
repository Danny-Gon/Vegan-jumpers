using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    
    public GameObject characterSelector;

    private void Start()
    {
        characterSelector.SetActive(false);
    }

    public void CharacterSelector()
    {
        characterSelector.SetActive(true);
    }

    public void ChangeScene(int sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

