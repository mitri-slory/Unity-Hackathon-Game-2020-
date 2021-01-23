using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioSource audio;
    public string tag;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag) && !audio.isPlaying)
            audio.Play();
    }
}
