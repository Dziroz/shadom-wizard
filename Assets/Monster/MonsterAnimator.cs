using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimator : MonoBehaviour
{
    public Animator anim;
    private GameObject Player;
    public float Dist_Player;
    public float distattack;


    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    void Update()
    {
        Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (Dist_Player < distattack)
        {
            anim.SetBool("isAttack", true);
        }
        else
        {
            anim.SetBool("isAttack", false);
        }
    }
}
