using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bulet : MonoBehaviour
{
    /*    public float buletLife = 1f;  // Defines how long before the bullet is destroyed
        public float rotation = 0f;
        public float speed = 1f;


        private Vector3 spawnPoint;
        private float timer = 0f;


        // Start is called before the first frame update
        void Start()
        {
            spawnPoint = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }


        // Update is called once per frame
        void Update()
        {
            if (timer > buletLife) Destroy(this.gameObject);
            timer += Time.deltaTime;
            transform.position = Movement(timer);
        }


        private Vector3 Movement(float timer)
        {
            // Moves right according to the bullet's rotation
            float x = timer * speed * transform.right.x;
            float z = timer * speed * transform.right.z;
            return new Vector3(x + spawnPoint.x, spawnPoint.y, z + spawnPoint.z);
        }*/
    public Rigidbody rb;
    public GameObject dirdot;
    Vector3 direction;
    public float power;
    void Start()
    {
        Destroy(this.gameObject, 15f);
        direction = dirdot.transform.position - transform.position;
    }

    void Update()
    {

    }
    private void FixedUpdate()
    {
        rb.velocity = (direction * power);
    }

}

