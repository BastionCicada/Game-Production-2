using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageController : MonoBehaviour
{


    public float rotateSpeed = 0f;
    public Vector3 rotationVector = new Vector3 (0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
        transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
        }
        if(Input.GetKey("s"))
        {
        transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed);
        }
        if(Input.GetKey("a"))
        {
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
        }
        if(Input.GetKey("d"))
        transform.Rotate(Vector3.back * Time.deltaTime * rotateSpeed);
        
    }
}
