using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Fishka : MonoBehaviour
{
    public GameObject amlet;
    public float speed;
    public Data data;
    public AudioClip clip, ded;
    public Vector3 translate;
    private Vector3 looker;
    private void Start()
    {
        speed = Screen.height / 8;
        looker = translate - transform.position;
    }
    public void OnTranslate(Vector3 tooSet) 
    {
        looker = tooSet - transform.position;
    }
    private void Update()
    {
        transform.position += looker.normalized * speed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            data.record += 1;
            SoundPlayer.regit.Play(clip, 1);
            SaveAndLoad.Instance.Save();
            Destroy(gameObject);
        }
        if (collision.tag == "Enemy")
        {
            SoundPlayer.regit.Play(ded, 1);
            GameObject des = Instantiate(amlet);
            des.transform.position = transform.position;
            des.transform.SetParent(collision.transform);
            des.transform.localScale = new Vector3(1,1,1);
            Helse.rid.helse -= 1;
            Destroy(des, 1);
            Destroy(gameObject);
        }
    }
}
