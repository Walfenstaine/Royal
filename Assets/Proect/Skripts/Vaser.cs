using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaser : MonoBehaviour
{
    public List<Fire> fires;
    public ParticleSystem ps;
    public bool onWaser;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Fire") 
        {
            fires.Add(other.GetComponent<Fire>());
        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Fire")
        {
            fires.Remove(other.GetComponent<Fire>());
        }
           
    }
    private void FixedUpdate()
    {
        if (fires.Count <= 0)
        {
            onWaser = false;
        }
        else 
        {
            onWaser = true;
        }
        if (onWaser)
        {
            for (int i = 0; i < fires.Count; i++)
            {
                fires[i].helse -= Time.unscaledDeltaTime;
                if (fires[i] == null) 
                {
                    fires.Remove(fires[i]);
                }
            }
            ps.Play();
        }
        else 
        {
            ps.Stop();
        }
    }
}
