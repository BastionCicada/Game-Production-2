using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentCoins;
    public AudioSource CoinGrab;
   

    // Start is called before the first frame update
    void Start()
    {
        CoinGrab = gameObject.GetComponent<AudioSource>(); 
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin") // If the player touches something with the coin tag
        {
        currentCoins++; // Adds coins to the canvas script
        other.gameObject.SetActive(false); // turns the active coin off
        CoinGrab.Play(); // plays coin sound

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coins: " + currentCoins.ToString(); // updates the scoretext to the current coins 
    }
}
