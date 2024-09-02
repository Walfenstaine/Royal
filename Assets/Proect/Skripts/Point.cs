using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public Transform[] points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy") 
        {
            int num = Random.Range(0, points.Length - 1);
            other.GetComponent<Mob_AI>().RePoint(points[num]);
        }
    }
}
