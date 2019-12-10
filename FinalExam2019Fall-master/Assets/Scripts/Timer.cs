using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float Timing;
    public static string asd;
    public Dropdown Timeset;
    
     public Text timeLimitText;
    public Text remainingTimeText;
    public static float timeRemaining;

    public void SettingTime()
    {
        if (Timeset.value == 1)
            asd = "60";
        else if (Timeset.value == 2)
            Timing = 120f;
        else if (Timeset.value == 3)
            Timing = 180f;
        else Timing = 60f;

        Debug.Log(Timing);
    }
    void Start()
    {
        timeRemaining = Timing;

        timeLimitText.text = "time limit: " + Timing.ToString("F2");
        remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
    }


  
    void Update()
    {
        
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            remainingTimeText.text = "game over";
        }
    }


    

}
