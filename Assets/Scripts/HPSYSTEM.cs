using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPSYSTEM : MonoBehaviour
{
    public int hp;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            hp--;
            Debug.Log("udar");
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            hp--;
            Debug.Log("udar");

        }
    }
}
