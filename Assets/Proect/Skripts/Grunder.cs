using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Grunder : MonoBehaviour
{
    public UnityEvent[] sumer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Grund")
        {
            sumer[0].Invoke();
        }
        else
        {
            if (collision.tag == "Killer") 
            {
                Interface.rid.Sum(2);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Grund")
        {
            sumer[1].Invoke();
        }
    }
}
