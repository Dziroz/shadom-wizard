using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TELEPORT : MonoBehaviour
{
    public int sceneNumber;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void load()
    {
        SceneManager.LoadScene(sceneNumber);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            load();
        }
    }

}
