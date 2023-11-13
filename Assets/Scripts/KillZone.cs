using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player"))
       {
        Debug.Log("Died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       }  
    }


    void Update()
    {
        
    }
}
