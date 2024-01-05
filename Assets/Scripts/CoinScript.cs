using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentCoins;
    public AudioSource coingrab;
   

    // Start is called before the first frame update
    void Start()
    {
        coingrab = gameObject.GetComponent<AudioSource>();
    }


    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
        currentCoins++;
        Col.gameObject.SetActive(false);
        coingrab.Play();

        }
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coins: " + currentCoins.ToString();
    }
}
