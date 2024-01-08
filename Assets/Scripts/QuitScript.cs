using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{
public void QuitProccess()
{
    Application.Quit(); // quits the application
    Debug.Log("Exited");
}
}
