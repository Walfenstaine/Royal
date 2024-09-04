using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InstantGamesBridge;

public class InputPK : MonoBehaviour
{
    public void Jump() 
    {
        ColorRemainer.rid.Remein();
    }
    public void Muw(int muw) 
    {
        ColorRemainer.rid.Muw(muw);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Interface.rid.Sum(0);
        }
        if (Input.GetKeyDown(KeyCode.W)|| Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Bridge.device.type != InstantGamesBridge.Modules.Device.DeviceType.Desktop)
        {
            Muw((int)Input.GetAxis("Horizontal"));
        }
    }
}
