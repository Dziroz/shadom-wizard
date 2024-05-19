using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobSpawn : MonoBehaviour
{
    public int mobsCount;
    public float timer;
    public float cooldown;
    public int x = 0;
    public int y = 0;
    public GameObject[] mobsPrefab;
    private GameObject Player;
    [SerializeField] float Dist_Player;
    public float distancerl;



    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Dist_Player = Vector3.Distance(Player.transform.position, gameObject.transform.position);

        if(Dist_Player  < distancerl)
        {
            Spawn();
        }
        timer += Time.deltaTime;
    }
    void Spawn()
    { 
        if(x <= mobsCount && timer > cooldown)
        {
            
            if(y>= mobsPrefab.Length)
            {
                y = 0;
            }
            Instantiate(mobsPrefab[y], transform.position, Quaternion.identity);
            y++;
            x++;
            timer = 0;



        }
    }
}
