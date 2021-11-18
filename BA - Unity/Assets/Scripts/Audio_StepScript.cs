using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_StepScript : MonoBehaviour
{
    public AudioClip[] grassSteps;
    private AudioSource thisAudiosource;

    private void Start()
    {
        thisAudiosource = GetComponent<AudioSource>();
    }


    void Randomizeclip()
    {
        int i = Random.Range(0, grassSteps.Length);
        thisAudiosource.clip = grassSteps[i];
    }

    void playStep()
    {
        Randomizeclip();
        thisAudiosource.Play();
    }
}
