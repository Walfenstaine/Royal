using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Comand : MonoBehaviour
{
    public Image[] imgs;

    void Start()
    {
        for (int i = 0; i < imgs.Length; i++) 
        {
            imgs[i].color = ColorRemainer.rid.colors[i];
        }
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < imgs.Length; i++)
        {
            if (i == ColorRemainer.rid.num)
            {
                imgs[i].transform.localScale = new Vector3(1,1,1);
            }
            else 
            {
                imgs[i].transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            }
        }
    }
}
