using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  
  public float mouseSensitivity; // the sensitivity of the mouse
  
  private float rotationY; 
  private float rotationX;

  public Transform Target; // this defines what the camera is targeting, in this case this will be the player

  public float distanceFromTarget; // this is the active distance from the target
  
  private Vector3 activeRotation; // the current movement of the camera
  private Vector3 smoothVelocity = Vector3.zero;

  public float smoothTime = 0.2f; // this adds smoothing to the camera

  public Vector2 rotationXMinMax = new Vector2(-20,20); // this is the default clamping value of the camera

    



    void Start()
    {
      Cursor.lockState = CursorLockMode.Locked; // starts the game locking the mouse
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationY += mouseX; // this sets the rotations of the mouse 
        rotationX -= mouseY;

        // Clamps the camera to a specific rotation
        rotationX = Mathf.Clamp(rotationX, rotationXMinMax.x, rotationXMinMax.y);

        Vector3 nextRotation = new Vector3(rotationX, rotationY);

        activeRotation = Vector3.SmoothDamp(activeRotation, nextRotation, ref smoothVelocity, smoothTime);
        transform.localEulerAngles = activeRotation;

        transform.position = Target.position - transform.forward * distanceFromTarget;

        
    }
}
