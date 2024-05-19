using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rb;
    GameObject Player;
    Vector3 direction;
    public float power;
    void Start()
    {
        Destroy(gameObject, 5);
        Player = GameObject.FindGameObjectWithTag("Player");
        direction = Player.transform.position-transform.position;
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {

        rb.AddForce(direction*power);
    }

}
