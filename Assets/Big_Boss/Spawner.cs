using System.Collections;
using System.Collections.Generic;
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
    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        timer += Time.deltaTime;
        if (spawnerType == SpawnerType.Spin) transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);
        if (timer >= firingRate)
        {
            timer = 0f;
            Fire();
        }
    }

    Vector3 V = new Vector3(0, 2f, 0);
    private void Fire()
    {
        int i = Random.Range(0, bulets.Length);
            Instantiate(bulets[i], transform.position - V, Quaternion.identity);
         /*   spawnedBulet.GetComponent<Bulet>().speed = speed;
            spawnedBulet.GetComponent<Bulet>().buletLife = buletLife;*/
            spawnedBulet.transform.rotation = transform.rotation;
    }
}


