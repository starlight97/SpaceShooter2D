using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;

    private void Start()
    {
        //AudioContorl();
    }

    private void AudioContorl()
    {
        float masterVolume = -10;

        if (masterVolume == -40f)
            masterVolume = -80;

        audioMixer.SetFloat("Master", masterVolume);

    }
}
