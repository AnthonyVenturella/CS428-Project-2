using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Vuforia;

public class btn_press : MonoBehaviour{

    public GameObject button;
    public AudioClip spawnSound;
    public AudioSource m_MyAudioSource;

    public Animator anim;

    void Start(){

        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        button.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb) {

        Debug.Log("Pressed");
        anim.SetTrigger("TypeToSit");
        m_MyAudioSource.Play();
        StartCoroutine(sitdown());

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {

        Debug.Log("Releassed");
    }

    IEnumerator sitdown() {
        yield return new WaitForSeconds(2);
        anim.SetTrigger("SitToType");
    }

}
