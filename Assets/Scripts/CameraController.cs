using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  
  public float mouseSensitivity;
  
  private float rotationY;
  private float rotationX;

  public Transform Target;

  public float distanceFromTarget;
  
  private Vector3 activeRotation;
  private Vector3 smoothVelocity = Vector3.zero;

  public float smoothTime = 0.2f;

  public Vector2 rotationXMinMax = new Vector2(-20,20);

  
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        // Clamps the camera to a specific rotation
        rotationX = Mathf.Clamp(rotationX, rotationXMinMax.x, rotationXMinMax.y);

        Vector3 nextRotation = new Vector3(rotationX, rotationY);

        activeRotation = Vector3.SmoothDamp(activeRotation, nextRotation, ref smoothVelocity, smoothTime);
        transform.localEulerAngles = activeRotation;

        transform.position = Target.position - transform.forward * distanceFromTarget;
    }
}
