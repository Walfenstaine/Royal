using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;
public class Portal : MonoBehaviour
{
    public UnityEvent sumer;
    public GameObject port;
    public int activ;
    public static Portal rid { get; set; }
    void Awake()
    {
        if (activ == 0)
        {
            port.SetActive(true);
        }
        else 
        {
            port.SetActive(false);
        }
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
    public void Activate() 
    {
        activ -= 1;
        if (activ == 0) 
        {
            port.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (activ == 0)
            {
                sumer.Invoke();
            }
            else 
            {
                Masager.rid.OnMasage(true);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (activ > 0)
            {
                Masager.rid.OnMasage(false);
            }
        }
    }
}