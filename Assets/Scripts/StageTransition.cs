using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTransition : MonoBehaviour
{
    public int SceneID;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")) // If collided has tag player then
        {
            Debug.Log("Teleported");
            SceneManager.LoadScene(SceneID); // teleports the player to selected sceneid through script
            Cursor.lockState = CursorLockMode.None; // this is a sneaky work around to the menu cursor lock issue when taken back to the menu
        }
    }


    void Update()
    {
        
    }
}
