using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class LEVELHUINYA : MonoBehaviour
{
    public TextMeshProUGUI textTimer;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textTimer.text = ((int)timer).ToString();
        if (timer <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
