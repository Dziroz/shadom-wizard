using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class HPSYSTEM : MonoBehaviour
{
    static public int hp;
    static public float timera;
    public TextMeshProUGUI hptext;
    public int x;

    
    void Start()
    {
        hp = 10;
        timera = 0;
    }

    void Update()
    {
        if(hp <= 0)
        {
            SceneManager.LoadScene(x);
        }
        timera += Time.deltaTime;
        hptext.text = hp.ToString();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.tag == "Bullet")
        {

            Destroy(collision.gameObject);
            if (timera > 1.5f)
            {
                hp--;
            }
            timera = 0;
            Debug.Log("udar");
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(collision.gameObject);
            if (timera > 1.5f)
            {
                hp--;
            }
            timera = 0;
            Debug.Log("udar");

        }
    }
}
