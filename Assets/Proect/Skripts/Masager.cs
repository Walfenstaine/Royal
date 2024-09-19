using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Masager : MonoBehaviour
{
    public GameObject masager;
    public static Masager rid { get; set; }
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
    public void OnMasage(bool active) 
    {
        masager.SetActive(active);
    }
}
