using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBallMover : MonoBehaviour
{
    private float maxSpeed;
    public Rigidbody rigid;
    public float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetAxis("Horizontal") > 0)
        {
            rigid.AddForce(Vector3.right * currentSpeed); // adds force going right
        }
        else if (Input.GetAxis("Horizontal") < 0) 
        {
            rigid.AddForce(Vector3.left * currentSpeed); // adds for going left by subtracting the force

        }

        if (Input.GetAxis("Vertical") > 0)
        {
            rigid.AddForce(Vector3.forward * currentSpeed); 
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            rigid.AddForce(Vector3.back * currentSpeed);
        }
    }
}
