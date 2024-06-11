using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    private SceneTransition sceneTransition;

    private void Start()
    {
        // Encontrar el objeto SceneTransition en la escena
        sceneTransition = FindObjectOfType<SceneTransition>();
    }

    public void ChangeScene(string sceneName)
    {
        if (sceneTransition != null)
        {
            sceneTransition.FadeToScene(sceneName);
        }
        else
        {
            Debug.LogWarning("No SceneTransition component found in the scene.");
        }
    }
}
