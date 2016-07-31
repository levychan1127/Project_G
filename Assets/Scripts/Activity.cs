using UnityEngine;
using System.Collections;

public class Activity{

    public bool isEngage;
    public float timeLimit;
    public float interval;
    public Timer activityTimer;
    public Timer intervalTimer;


    public Activity(float activitySec,float intervalSec)
    {
        timeLimit = activitySec;
        interval = intervalSec;
    }

    // Update is called once per frame
/*    public void Update(float updateTime)
    {
        activityTimer.Update(updateTime);
        intervalTimer.Update(updateTime);
    }
*/

    public void ActivityStart()
    {
        activityTimer = new Timer(timeLimit);
        intervalTimer = new Timer(interval);
        activityTimer.trig += ActiviyEnd;
        intervalTimer.trig += ActivityFunc;
        activityTimer.Start();
        intervalTimer.Start();
    }

    public void ActivityFunc()
    {
        intervalTimer = new Timer(interval);
        intervalTimer.trig += ActivityFunc;
        intervalTimer.Start();
        Debug.Log("act");

    }

    public void ActiviyEnd()
    {
        intervalTimer.Stop();
    }

}
