using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class zoom : MonoBehaviour
{
    [SerializeField] Camera PlayerCam;
    private void Update()
    {
        if (kile.punch) zoomer();
    }
    public void zoomer()
    {
        PlayerCam.fieldOfView = 30;
        Invoke("Obratka",1);
    }
    private void Obratka()
    {
        PlayerCam.fieldOfView = 60;
    }
}