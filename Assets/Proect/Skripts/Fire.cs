using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Data data;
    public Transform smok, fir;
    public float helse;
    private bool damag;
    private float timer;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            damag = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            damag = false;
        }
    }
    private void FixedUpdate()
    {
        if (damag) 
        {
            if (Time.time > timer) 
            {
                timer = Time.time + 0.5f;
                Muwer.rid.helse -= 1;
            }
        }
        float hels = helse / 5;
        fir.localScale = new Vector3(hels, hels, hels);
        smok.localScale = new Vector3(hels, hels-0.5f, hels);
        if (helse <= 0.2f) 
        {
            data.record += 1;
            SaveAndLoad.Instance.Save();
            Destroy(gameObject);
        }
    }
}
