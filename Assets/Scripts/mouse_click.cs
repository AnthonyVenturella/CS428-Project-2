using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_click : MonoBehaviour
{
    public Transform startPos;
    public GameObject bouncieBall;
    public GameObject desktop;
    public int SpawnAmount = 10;

    private bool showDesktop = false;

    private void Start() {
        desktop.gameObject.SetActive(showDesktop);
    }

    void Update() {
        
        Vector3 randomPos;

        if (Input.GetMouseButtonDown(0)) {

            //randomPos = new Vector3(Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f), Random.Range(-0.5f, 0.5f));

            for(int i = 0; i < SpawnAmount; i++) {
                randomPos = new Vector3(Random.Range(-10.5f, 10.5f), Random.Range(-10.5f, 10.5f), Random.Range(-10.5f, 10.5f));
                Instantiate(bouncieBall, startPos.position + randomPos, startPos.rotation);
                bouncieBall.GetComponent<Rigidbody>().AddForce(0, -10, 0);
            }

        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            showDesktop = !showDesktop;

            desktop.gameObject.SetActive(showDesktop);
        }
    }
}