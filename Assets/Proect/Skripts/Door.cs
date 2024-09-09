using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public BoxCollider2D colider;
    public SpriteRenderer[] rendrs;

    public void Open(bool open) 
    {
        rendrs[0].enabled = open;
        rendrs[1].enabled = !open;
        colider.enabled = !open;
    }
}
