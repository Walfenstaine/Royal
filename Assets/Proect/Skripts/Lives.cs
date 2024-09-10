using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{
    public Data data;
    public GameObject[] herses;
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
}
