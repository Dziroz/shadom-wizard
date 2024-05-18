using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShaker : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCamera vCamera;

    private void Update()
    {

    }
    IEnumerator Shake(float Amplitude, float Frequency)
    {
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = Amplitude;
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = Frequency;
        yield return new WaitForSeconds(1);
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        vCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
    }
    public void Shaker(float Amplitude, float Frequency)
    {
        StartCoroutine(Shake(Amplitude, Frequency));
    }
    
}