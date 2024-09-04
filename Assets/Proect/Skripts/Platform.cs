using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public BoxCollider2D colider;
    public SpriteRenderer[] sprites;
    public int num;

    private void Start()
    {
        Remain();
    }

    public void Remain() 
    {
        for (int i = 0; i < sprites.Length; i++) 
        {
            sprites[i].color = ColorRemainer.rid.colors[num];
        }
    }

    public void Recolor() 
    {
        num = Random.Range(0, ColorRemainer.rid.colors.Length-1);
        Remain();
    }

    private void FixedUpdate()
    {
        if (num == ColorRemainer.rid.num)
        {
            colider.enabled = true;
        }
        else 
        {
            colider.enabled = false;
        }
    }
}
