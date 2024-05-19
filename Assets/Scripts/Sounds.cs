using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audio;
    [SerializeField] AudioClip[] stepsAudio;
    public int x;
    float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (AnimatorController.isRunning && timer>=0.5f)
        {
            audioSource.PlayOneShot(stepsAudio[x]);
            x++;
            timer = 0;
            if(x >= stepsAudio.Length)
            {
                x = 0;
            }
        }
    }
    public void Sound(int x)
    {
        audioSource.PlayOneShot(audio[x]);
    }
}
