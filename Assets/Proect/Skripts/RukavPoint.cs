using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class RukavPoint : MonoBehaviour
{
    public NavMeshAgent agent;
    public enum Pose { norm, stat }
    public Pose pose;
    public Transform next;

    private void Start()
    {
        if (pose == Pose.stat) 
        {
            transform.parent = next;
            transform.localPosition = Vector3.zero;
            Destroy(this);
        }
    }
    private void FixedUpdate()
    {
        if (agent != null)
        {
            agent.destination = next.position;
        }
        else 
        {
            Vector3 nec = new Vector3(next.position.x, transform.position.y, next.position.z);
            transform.LookAt(nec);
            transform.position = Vector3.Lerp(transform.position, next.position - next.forward / 2, 5.5f * Time.fixedDeltaTime);
        }
    }
}
