using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Mob_AI : MonoBehaviour
{
    public bool runing;
    public float interval;
    public Transform target;
    public NavMeshAgent agent;
    public Animator anim;
    private float timer;
    void Start()
    {
        GameObject[] targ = GameObject.FindGameObjectsWithTag("Point");
        int num = Random.Range(0, targ.Length-1);
        target = targ[num].transform;
    }

    public void RePoint(Transform wey) 
    {
        runing = false;
        timer = Time.time + interval;
        target = wey;
    }
    private void FixedUpdate()
    {
        if (runing)
        {
            agent.isStopped = false;
            agent.destination = target.position;
        }
        else 
        {
            agent.isStopped = true;
            if (Time.time > timer) 
            {
                runing = true;
            }
        }
        anim.SetBool("Run", runing);
        anim.SetFloat("Speed", agent.velocity.magnitude/2);
    }
}
