using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource CoinGrab;
    public AudioSource PlayerJump;
    // Start is called before the first frame update
    
    // this is an attempt to try and fix the audio bug, doesn't seem to work 
    
    void Start()
    {
        CoinGrab = gameObject.AddComponent<AudioSource>();
        PlayerJump = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
