using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundtrigger1 : MonoBehaviour
{
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("SOUND");
        playSound.Play();

    }
}
