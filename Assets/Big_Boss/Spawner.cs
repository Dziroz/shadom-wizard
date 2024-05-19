using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;


public class BuletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin}


    [Header("Bulet Attributes")]
    public GameObject[] bulets;
    public float buletLife = 1f;
    public float speed = 1f;


    [Header("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    [SerializeField] private float firingRate = 1000f;


    private GameObject spawnedBulet;
    public GameObject sprayy;
    public GameObject laser;
    private float timer = 0f;
    private float timer_las = 0f;
    private int count = 0;
    private int i = 0;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        timer_las += Time.deltaTime;
        // if (spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);
        if (timer_las >= 10f)
        {
            timer = 0f;
            timer_las = 0f;
            Invoke("las", 0);
            Invoke("las", 1f);
            Invoke("las", 2f);

        }
        if (timer >= firingRate)
        {
            timer = 0f;
            Fire();
        }
    }

    public void spray()
    {
        Instantiate(sprayy, transform.position - V, Quaternion.identity);
    }
    Vector3 V = new Vector3(0, 2f, 0);
    Vector3 V_l = new Vector3(0, 2f, 0);
    private void Fire()
    {
        int i = Random.Range(0, bulets.Length);
        if (i == 0)
        {
            for (int j = 0; j < 3; j++)
            {
                Invoke("spray", j);
            }
        }
        else
        {
            Instantiate(bulets[i], transform.position - V, Quaternion.identity);
        }
    }
    public void las()
    {
        Instantiate(laser, transform.position - V_l, Quaternion.identity);
    }
}


