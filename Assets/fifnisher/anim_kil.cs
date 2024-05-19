using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class anim_kil : MonoBehaviour
{
    public Animator anime;
    Vector3 vr = new Vector3(0,1,0);
    [SerializeField] Camera PlayerCam;
    public void finishHim()
    {
        PlayerCam.fieldOfView = 30;
        anime.SetBool("livin", true);
        anime.Play("mixamo_com");
        Invoke("schoolShoot", 1f);
        PlayerCam.transform.position -= vr;
    }
    public void schoolShoot()
    {
        PlayerCam.transform.position += vr;
        anime.SetBool("livin", false);
        PlayerCam.fieldOfView = 60;
        kile.punch = false;
    }
}
