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
       if(other.CompareTag("Player"))
       {
        Debug.Log("Died");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        death.Play();

       }  
    }

    void Update()
    {
        
    }
}
