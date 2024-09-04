using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobUpr : MonoBehaviour
{
    public InputPK ip;
    public void Muw(int muw) 
    {
        ip.Muw(muw);
    }
    public void Jump()
    {
        ip.Jump();
    }
}
