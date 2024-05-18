using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class anim_kil : MonoBehaviour
{
    public Animator anime;
    public void finishHim()
    {
        anime.SetBool("livin", true);
        anime.Play("mixamo_com");
        Invoke("schoolShoot", 1);
    }
    public void schoolShoot()
    {
        anime.SetBool("livin", false);
    }
}
