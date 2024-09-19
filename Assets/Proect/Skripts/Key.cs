using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public AudioClip clip;


    private void Start()
    {
        Portal.rid.activ += 1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Portal.rid.Activate();
            SoundPlayer.regit.Play(clip, 1);
            Destroy(gameObject);
        }
    }
}
