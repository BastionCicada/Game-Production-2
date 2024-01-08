using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallMover : MonoBehaviour
{
    private float maxSpeed; // maximum possible speed
    public Rigidbody rigid; // the rigid body component
    public Transform cam; // active camera for the player 
    public float force; // this is used for the general force of the player
    private bool groundedPlayer = true; // this checks if the player is grounded
    public AudioSource PlayerJump; // this is the sound of the player jumping

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>(); // this calls the rigidbody component from the editor
        PlayerJump = gameObject.GetComponent<AudioSource>(); // this calls the audio source component from the editor
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey("d")) // if D is pressed
        {
            rigid.AddForce(new Vector3(cam.right.x, 0, cam.right.z).normalized * force); // this adds force normalised to the current position of the camera
        }
    
        if (Input.GetKey("a")) // if A is pressed
        {
            rigid.AddForce(new Vector3(cam.right.x, 0, cam.right.z).normalized * -force);
        }
    
        if (Input.GetKey("w")) // if W is pressed
        {
            rigid.AddForce(new Vector3(cam.forward.x, 0, cam.forward.z).normalized * force);
        }
    
        if (Input.GetKey("s")) // if S is pressed
        {
            rigid.AddForce(new Vector3(cam.forward.x, 0, cam.forward.z).normalized * -force);
        }
    }

    void Update()
    {
        if(Input.GetButtonDown("Jump") && groundedPlayer) // if space is pressed and the player is grounded
        {
            rigid.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse); // this sets the force upwards
            Debug.Log("Jumped");
            Physics.gravity = new Vector3(0, -25, 0); // this adds artifical gravity to the player
            groundedPlayer = false; // this turns the grounded plyer bool off to prevent double / triple jumping issues
            PlayerJump.Play(); // this plays the player sound
        }
    }  

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Floor") // checks if the player is in contact with the floor
        {
            groundedPlayer = true;
        }
    }
}
