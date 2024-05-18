using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audio;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Sound(int x)
    {
        audioSource.PlayOneShot(audio[x]);
    }
}
