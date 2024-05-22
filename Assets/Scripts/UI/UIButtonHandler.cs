using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonHandler : MonoBehaviour
{

    public Button playBttn;
    public Button options;
    public Button restart;
    public Button help;

    // Start is called before the first frame update
    void Start()
    {
        if (playBttn != null) 
        {
            playBttn.onClick.AddListener(OnButtonClick);
            options.onClick.AddListener(OnButtonClick);
            restart.onClick.AddListener(OnButtonClick);
            help.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick()
    {
        Debug.Log("Boton Presionado");
    }
}
