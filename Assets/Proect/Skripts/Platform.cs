using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public BoxCollider2D[] colider;
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
        num = Random.Range(0, ColorRemainer.rid.colors.Length);
        Remain();
    }

    private void FixedUpdate()
    {
        for (int i = 0; i < colider.Length; i++)
        {
            if (num == ColorRemainer.rid.num)
            {
                colider[i].enabled = true;
            }
            else
            {
                colider[i].enabled = false;
            }
        }
    }
}
