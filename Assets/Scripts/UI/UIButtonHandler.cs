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
    public Button removeAdds;
    public Button horseOne;
    public Button horseTwo;
    public Button horseThree;
    public Button horseFour;

    void Start()
    {
        if (playBttn != null) 
        {
            playBttn.onClick.AddListener(OnButtonClick);
            options.onClick.AddListener(OnButtonClick);
            restart.onClick.AddListener(OnButtonClick);
            help.onClick.AddListener(OnButtonClick);
            removeAdds.onClick.AddListener(OnButtonClick);
            horseOne.onClick.AddListener(OnButtonClick);
            horseTwo.onClick.AddListener(OnButtonClick);
            horseThree.onClick.AddListener(OnButtonClick);
            horseFour.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick()
    {
        Debug.Log("Boton Presionado");
    }
}
