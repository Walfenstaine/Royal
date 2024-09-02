using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Creator : MonoBehaviour
{
    public Transform translate;
    public float interval, upper;
    public GameObject fishka;
    private float timer;


    private void Start()
    {
        timer = Random.Range(interval / 2, interval * 2);
    }
    private void FixedUpdate()
    {
        float inter = Random.Range(interval/2, interval*2);
        if (Time.time > timer) 
        {
            timer = Time.time + inter;
            Create();
        }
    }
    public void Create()
    {
        if (interval > 2.0f) 
        {
            interval -= 0.01f;
        }
        Transform fish = Instantiate(fishka).transform;
        fish.position = transform.position;
        fish.SetParent(transform);
        fish.localScale = new Vector3(1,1,1);
        fish.GetComponent<Fishka>().translate = translate.position;
    }
}
