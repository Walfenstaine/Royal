using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    void Update()
    {
        Vector3 target = ColorRemainer.rid.transform.position + new Vector3(ColorRemainer.rid.rb.velocity.x * 2, 0, 0);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);
    }
}
