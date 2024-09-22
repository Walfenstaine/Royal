using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    

    
        
    

    void OnTriggerEnter2D(Collider2D other)

    {
        if(other.gameObject.tag == "Player")
        {
            ColorRemainer.rid.Recolor();
        }
    }

}
