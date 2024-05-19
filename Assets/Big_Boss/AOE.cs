using System.Collections;
using System.Collections.Generic;
using TopDownShooter;
using UnityEngine;

public class AOE : MonoBehaviour
{
    public GameObject meleepatern;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Invoke("AYE", 1.5f);
        }
    }
    private void AYE()
    {
        meleepatern.SetActive(true);
        Invoke("AYE_exit", 2.5f);
    }

    private void AYE_exit()
    { 
        meleepatern.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
