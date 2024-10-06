using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPK : MonoBehaviour
{
    public AudioClip jump;
    public void Jump() 
    {
        SoundPlayer.regit.Play(jump, 1);
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
        //if (Bridge.device.type != InstantGamesBridge.Modules.Device.DeviceType.Mobile)
        // {
        // Muw((int)Input.GetAxis("Horizontal"));
        // }
        Muw((int)Input.GetAxis("Horizontal"));
    }
}
