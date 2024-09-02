using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Wheel : MonoBehaviour
{
    public NavMeshAgent agent;
    private float rut;
    void Update()
    {
        transform.localEulerAngles = new Vector3(rut,0,0);
        if (rut < 360)
        {
            rut += agent.velocity.magnitude * 10 * Time.deltaTime;
        }
        else 
        {
            rut = 0;
        }
    }
}
