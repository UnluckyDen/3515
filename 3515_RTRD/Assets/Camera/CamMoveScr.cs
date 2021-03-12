using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class CamMoveScr : MonoBehaviour
{

    public Transform campos;
    private Camera cam;
    public bool test;
    
    

    void Start()
    {
        cam = Camera.main;
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider camtrigger)
    {
        if (camtrigger.name == ("PlayerHolder"))
        {
            cam.transform.position = campos.transform.position;
            cam.transform.rotation = campos.transform.rotation;
        }
    }
}
