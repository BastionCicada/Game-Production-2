using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinRotation : MonoBehaviour
{
    public float speed; // this is the controlled speed 
    public Vector3 rotation; // this is the rotation angle
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(rotation * speed * Time.deltaTime); // this controls the rotation and the speed of the coin timed by the frame time
    }
}
