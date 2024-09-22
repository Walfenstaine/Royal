using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRemainer : MonoBehaviour
{
    public float speed, jumpSpeed;
    public SpriteRenderer render;
    public Animator anim;
    public Color[] colors;
    public Rigidbody2D rb;
    public int num;
    private int muwer;
    public bool grunded;
    public static ColorRemainer rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    private void Start()
    {
        render.color = colors[num];
    }
    public void Recolor()

    {
        num = Random.Range(0 , colors.Length);
    }

    public void Remein() 
    {
        if (grunded)
        {
            rb.AddForce(transform.up * 100 * jumpSpeed);
            anim.SetTrigger("Jump");
        }
        else 
        {
            if (num < colors.Length - 1)
            {
                num += 1;
            }
            else
            {
                num = 0;
            }
        }
    }
    public void Grunded(bool isGrunded) 
    {
        grunded = isGrunded;
        if (isGrunded) 
        {
            anim.SetTrigger("Idle");
        }
    }
    public void Muw(int muw) 
    {
        muwer = muw;
       
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.right * speed * muwer);
        render.color = colors[num];
        if (muwer > 0) 
        {
            transform.localScale = new Vector3(5, 5, 5);
        }
        if (muwer < 0)
        {
            transform.localScale = new Vector3(-5, 5, 5);
        }
    }
}
