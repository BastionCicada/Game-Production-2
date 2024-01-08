using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillZone : MonoBehaviour
{
    public AudioSource death;
    // Start is called before the first frame update
    void Start()
    {
     death = gameObject.GetComponent<AudioSource>();
    }

    
    void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Player")) // checks if the player collides
       {
        Debug.Log("Died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // resets the scene
        death.Play();

       }  
    }

    void Update()
    {
        
    }
}
