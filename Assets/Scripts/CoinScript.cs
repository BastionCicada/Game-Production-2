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
        if(other.gameObject.tag == "Coin")
        {
        currentCoins++;
        other.gameObject.SetActive(false);
        CoinGrab.Play();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coins: " + currentCoins.ToString();
    }
}
