using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timertext;
    public Text Finish;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    
    void Update()
    {
        if (Finish.text == "Ganaste!")
        {
            timertext.color = Color.yellow;
            return;
        }
        float t = Time.time - startTime;
        string Minutos = ((int)t / 60).ToString();
        string Segundos = (t % 60).ToString("f2");

        if (t>60)
        {
            timertext.text = Minutos + ":" +Segundos;
        } else timertext.text = Segundos;
    }
}
