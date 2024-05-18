using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    public Animator anim;
    static public bool isShooting;
    static public bool isRunning;
    static public bool isPistol;
    static public bool isRifle;
    static public bool isDance;
    public float timer;
    int x = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) && isRunning == false)
        {
            switch (x)
            {
                case 0:
                    anim.Play("dance1");
                    break;
                case 1:
                    anim.Play("hiphop");
                    break;
                case 2:
                    anim.Play("wave");
                    break;
                case 3:
                    anim.Play("hiphop1");
                    break;
                default:
                    break;

            }
            x++;
            if (x > 3)
            {
                x = 0;
            }
        }
        timer += Time.deltaTime;
        anim.SetBool("isShooting", isShooting);
        anim.SetBool("isRunning", isRunning);
        anim.SetBool("isPistol", isPistol);
        anim.SetBool("isRifle", isRifle);
        Debug.Log(isRunning);
        if (timer > 1)
        {
            isShooting = false;
            timer = 0;
        }
    }
}
