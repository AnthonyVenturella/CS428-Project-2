using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btn_press : MonoBehaviour
{

    public GameObject button;

    void Start()
    {
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {

        Debug.Log("Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

        Debug.Log("Releassed");

    }

}
