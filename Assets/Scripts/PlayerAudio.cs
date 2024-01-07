using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    public AudioSource CoinGrab;
    public AudioSource PlayerJump;
    // Start is called before the first frame update
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
