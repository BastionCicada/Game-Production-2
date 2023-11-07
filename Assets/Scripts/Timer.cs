using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float TimeLeft;
    public bool TimerOn = false;
    public Text 


    // Start is called before the first frame update
    public void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeOn)
        {
            if(TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Times Up");
                TimeLeft = 0;
                TimeON = false;
            }
        }
    }

    void updateTimer(float currentTime)
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = stringFormat("{0;00} : {1:00}", minutes, seconds);
    }
}
