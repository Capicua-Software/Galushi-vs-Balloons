using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{

    public float timervalue = 0;
    TextMeshPro timertxt;
    
    
    void Start()
    {
        timertxt = GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timervalue>=0)
        {
            timervalue += Time.deltaTime;
        }
        else
        {
            timervalue = 0;
        }
        DisplayTime(timervalue);


    }

    void DisplayTime(float timetodisplay)
    {
        if (timetodisplay < 0)
        {
            timetodisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timetodisplay / 60);
        float seconds = Mathf.FloorToInt(timetodisplay % 60);

        timertxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
