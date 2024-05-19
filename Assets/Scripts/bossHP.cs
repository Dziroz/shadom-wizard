using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




namespace TopDownShooter
{
    public class bossHP : MonoBehaviour
    {
        public int HP;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(HP <= 0)
            {
                SceneManager.LoadScene(3);
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.transform.GetComponent<Damage>())
            {
                HP--;
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.GetComponent<Damage>())
            {
                HP--;
            }
        }
    }
}
