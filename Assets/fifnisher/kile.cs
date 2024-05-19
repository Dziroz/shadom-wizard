using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TopDownShooter;
using UnityEngine;

public class kile : MonoBehaviour
{
    AI_Monster enemy;
    public HitPoint hp;
    public bool CanBeFinished = false;
    public GameObject killbutt;
    public anim_kil animationkill;
    static public bool punch = false;
    void Start()
    {
        enemy = transform.parent.GetComponent<AI_Monster>();
        killbutt.SetActive(false);

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && hp.GetComponent<HitPoint>().CurrentHitPoint >=0 && CanBeFinished)
        {
            punch = true;
            animationkill.finishHim();
            hp.Dead();
            killbutt.SetActive(false);         
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag =="Player" && hp.GetComponent<HitPoint>().CurrentHitPoint <= hp.GetComponent<HitPoint>().MaxHitPoint * 0.15f)
        {
            CanBeFinished = true;
            killbutt.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && hp.GetComponent<HitPoint>().CurrentHitPoint <= hp.GetComponent<HitPoint>().MaxHitPoint * 0.15f)
        {
            CanBeFinished = false;
            killbutt.SetActive(false);
        }
    }
}
