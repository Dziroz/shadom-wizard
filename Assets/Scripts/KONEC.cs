using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KONEC : MonoBehaviour
{
    public float timer;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 17)
        {
            Application.Quit();
        }
    }
}
