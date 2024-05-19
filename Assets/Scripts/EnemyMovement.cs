using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI_Monster : MonoBehaviour
{
    public bool Shoting;
    private NavMeshAgent AI_Agent;
    private GameObject Player;
    public GameObject Panel_GaveOver;
    public float speed;
    public GameObject bulletPrefab;
    public GameObject bulletPoint;
    public float timer;
    public float Dist_Player;

    public float rotationModifier;

    void Start()
    {
        AI_Agent = gameObject.GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }
    void FixedUpdate()
    {
        
        AI_Agent.SetDestination(Player.transform.position);
        Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);
        if (Shoting)
        {
            if(Dist_Player < 10)
            {
                AI_Agent.speed = 0.1f;
                Shoot();
                
            }
            else
            {
                AI_Agent.speed = 3.5f;
            }
        }
        else
        {
            if (Dist_Player < 2)
            {
                AI_Agent.SetDestination(transform.position);
            }
        }

        


    }
    void Shoot()
    {
        if (timer > 1)
        {
            Instantiate(bulletPrefab, bulletPoint.transform.position, Quaternion.identity);
            timer = 0;
        }

    }
    
}