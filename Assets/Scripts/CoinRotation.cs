using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CoinRotation : MonoBehaviour
{
    public float speed;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.Rotate(rotation * speed * Time.deltaTime);
    }
}
