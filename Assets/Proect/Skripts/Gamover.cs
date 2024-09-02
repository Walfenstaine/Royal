using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamover : MonoBehaviour
{
    public void GameOver() 
    {
        Interface.rid.GamOver();
        SoundPlayer.regit.sorse.Stop();
    }
}
