using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int currentCoins;
   

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Coin")
        {
        currentCoins++;
        Col.gameObject.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Coins: " + currentCoins.ToString();
    }
}
