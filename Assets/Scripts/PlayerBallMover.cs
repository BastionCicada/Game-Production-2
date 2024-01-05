using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallMover : MonoBehaviour
{
    private float maxSpeed;
    public Rigidbody rigid;
    public Transform cam;
    public float force;
    private bool groundedPlayer = true;
    public AudioSource jumpsound;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
        jumpsound = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            rigid.AddForce(new Vector3(cam.right.x, 0, cam.right.z).normalized * force);
        }
    
        if (Input.GetKey("a"))
        {
            rigid.AddForce(new Vector3(cam.right.x, 0, cam.right.z).normalized * -force);
        }
    
        if (Input.GetKey("w"))
        {
            rigid.AddForce(new Vector3(cam.forward.x, 0, cam.forward.z).normalized * force);
        }
    
        if (Input.GetKey("s"))
        {
            rigid.AddForce(new Vector3(cam.forward.x, 0, cam.forward.z).normalized * -force);
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && groundedPlayer)
        {
            rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            Debug.Log("Jumped");
            Physics.gravity = new Vector3(0, -25, 0);
            groundedPlayer = false;
            jumpsound.Play();
        }
    }  

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor")
        {
            groundedPlayer = true;
        }
    }
}
