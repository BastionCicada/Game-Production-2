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


    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Portal")
        {
            Debug.Log("Teleported");
        }
    }


    void Update()
    {
        
    }
}
