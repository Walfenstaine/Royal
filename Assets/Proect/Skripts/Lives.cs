using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public AudioClip clip, liv;
    public Data data;
    public GameObject[] herses;
    public static Lives rid { get; set; }
    private int timer = 100;
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    
    void Start()
    {
        for (int i = 0; i < herses.Length; i++)
        {
            if (i < data.lives)
            {
                herses[i].SetActive(true);
            }
            else
            {
                herses[i].SetActive(false);
            }
        }
    }
    public void OnCoin() 
    {
        if (timer > 0)
        {
            SoundPlayer.regit.Play(clip,1);
            timer -= 1;
        }
        else 
        {
            SoundPlayer.regit.Play(liv, 1);
            data.lives += 1;
            timer = 100;
            Start();
        }
        data.record += 1;
        //SaveAndLoad.Instance.Save();
    }
}
