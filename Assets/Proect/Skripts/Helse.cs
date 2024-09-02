using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helse : MonoBehaviour
{
    public GameObject[] herze;
    public int helse;
    public static Helse rid { get; set; }
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
    private void FixedUpdate()
    {
        helse = Muwer.rid.helse;
        if (helse > 0)
        {
            for (int i = 0; i < herze.Length; i++)
            {
                if (helse > i)
                {
                    herze[i].SetActive(true);
                }
                else
                {
                    herze[i].SetActive(false);
                }
            }
        }
        else 
        {
            Interface.rid.GamOver();
            Muwer.rid.helse = herze.Length;
        }
    }
}
