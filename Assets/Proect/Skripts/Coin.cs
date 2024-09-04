using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip clip;
    public Data data;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            data.record += 1;
            SoundPlayer.regit.Play(clip,1);
            Destroy(gameObject);
        }
    }
}
