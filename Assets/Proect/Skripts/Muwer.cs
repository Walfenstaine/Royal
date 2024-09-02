using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muwer : MonoBehaviour
{
    public int helse;
    public LayerMask mask;
    public List<Transform> grund;
    public Animator anim;
    public CharacterController controller;
    public float rut;
    public Vector3 muve;
    public float sensitivity = 1.1f;
    public Transform cam, bady;
    public float speed;
    public float gravity = 20.0F;
    private bool grunded;
    private float jump;
    private Vector3 moveDirection = Vector3.zero;
    

    public static Muwer rid { get; set; }
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
    private void FixedUpdate()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 0.45f, mask);
        if (hitColliders.Length > 0)
        {
            grunded = true;
        }
        else 
        {
            grunded = false;
        }
        
    }
    void Update()
    {
        anim.SetFloat("Speed", controller.velocity.magnitude/speed);
        anim.SetBool("Jump", !grunded);
        cam.position = Vector3.Lerp(cam.position, transform.position + (new Vector3(controller.velocity.x, 0, controller.velocity.z)), 3.0f * Time.deltaTime);
        //Camera.main.transform.LookAt(transform);
        if (muve.y > -gravity)
        {
            muve.y -= gravity * Time.deltaTime;
        }
        if (cam != null)
        {
           cam.Rotate(cam.up * rut * sensitivity * Time.deltaTime);
        }
        if (grunded) 
        {
            moveDirection = muve; 
        }
        else
        {
            moveDirection = new Vector3(muve.x/2, muve.y, muve.z/2);
        }
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        controller.Move(moveDirection * Time.deltaTime);
        if (controller.velocity.x != 0 || controller.velocity.z != 0)
        {
            anim.SetBool("Run", true);
            bady.localRotation = Quaternion.Lerp(bady.localRotation, Quaternion.LookRotation(new Vector3(muve.x, 0, muve.z)), 3.5f * Time.deltaTime);
            transform.rotation = Quaternion.Lerp(transform.rotation, cam.rotation, 5.5f * Time.deltaTime);
        }
        else 
        {
            anim.SetBool("Run", false);
        }
    }
}

