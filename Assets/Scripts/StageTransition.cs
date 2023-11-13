using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("Teleported");
            SceneManager.LoadScene(1);
        }
    }


    void Update()
    {
        
    }
}