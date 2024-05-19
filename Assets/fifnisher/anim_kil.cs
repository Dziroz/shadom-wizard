using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class anim_kil : MonoBehaviour
{
    public Animator anime;
    [SerializeField] Camera PlayerCam;
    public void finishHim()
    {
        PlayerCam.fieldOfView = 30;
        anime.SetBool("livin", true);
        anime.Play("mixamo_com");
        Invoke("schoolShoot", 0.7f);
    }
    public void schoolShoot()
    {
        anime.SetBool("livin", false);
        PlayerCam.fieldOfView = 60;
        kile.punch = false;
    }
}
