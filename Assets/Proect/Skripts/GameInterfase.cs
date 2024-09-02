using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameInterfase : MonoBehaviour
{
    public Text record;
    public Data data;


    private void FixedUpdate()
    {
        record.text = "" + data.record;
       // Creator.rid.sensivity = sense.value * 10;
    }
}
