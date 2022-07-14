using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walking : MonoBehaviour
{
    public FirstPersonController controllScript;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void WalkFootsteps()
    {
        if (controllScript.isWalking && !audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
