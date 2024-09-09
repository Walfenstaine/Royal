using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Key : MonoBehaviour
{
    public AudioClip clip;
    public UnityEvent key;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            key.Invoke();
            SoundPlayer.regit.Play(clip, 1);
            Destroy(gameObject);
        }
    }
}
