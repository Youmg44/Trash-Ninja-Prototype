using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float timer = 10;
    public Text timeclock;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timeclock.text = timer.ToString();

        if (timer <= 0)
        {

        }
    }
}
