using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 0f;
    public TextMeshProUGUI textoTimer;
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimer.text = "" + timer.ToString("f0");

        if (timer <= 0f)
        {
            Debug.Log("GAME OVER");
        }
    }
}
