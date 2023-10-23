using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : MonoBehaviour
{
  void FixedUpdate()
  {
    if ((Input.GetKey(KeyCode.W)))
    {
        GetComponent<Rigidbody>().angularVelocity = Vector3.forward;
    }



  }
}
