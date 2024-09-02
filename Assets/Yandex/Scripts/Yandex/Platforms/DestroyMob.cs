using UnityEngine;
using InstantGamesBridge;

public class DestroyMob: MonoBehaviour
{
    void Awake()
    {
        if (Bridge.device.type != InstantGamesBridge.Modules.Device.DeviceType.Desktop)
        {
            gameObject.SetActive(false);
        }
    }
}