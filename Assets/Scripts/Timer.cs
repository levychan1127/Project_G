using System;
using System.Collections;

public class Timer
{
    public static ArrayList timerList = new ArrayList();


    //If the Timer is running 
    public bool isTicking;

    //Current time
    public float curTime;

    //Time to reach
    public float triggerTime;

    //Use delegate to hold the methods
    public delegate void EventHandler();

    //The trigger event list
    public event EventHandler trig;

    /// <summary>
    /// Init
    /// </summary>
    /// <param name="second">Trigger Time</param>
    public Timer(float second)
    {
        curTime = 0.0f;
        triggerTime = second;       
    }

    /// <summary>
    /// Start Timer
    /// </summary>
    public void Start()
    {
        //将实例本身添加到动态数组中
        if (!timerList.Contains(this))
        {
            timerList.Add(this);
        }        
        isTicking = true;
    }

    /// <summary>
    /// Update Time
    /// </summary>
    public void Update(float deltaTime)
    {
        if (isTicking)
        {
            curTime += deltaTime;

            if (curTime > triggerTime)
            {
                isTicking = false;
                timerList.Remove(this);
                trig();
            }
        }
    }

    /// <summary>
    /// Stop the Timer
    /// </summary>
    public void Stop()
    {
        timerList.Remove(this);
        isTicking = false;
    }

    /// <summary>
    /// Continue the Timer
    /// </summary>
    public void Continue()
    {
        isTicking = true;
    }

    /// <summary>
    /// Restart the this Timer
    /// </summary>
    public void Restart()
    {
        isTicking = true;
        curTime = 0.0f;
    }

    /// <summary>
    /// Change the trigger time in runtime
    /// </summary>
    /// <param name="second">Trigger Time</param>
    public void ResetTriggerTime(float second)
    {
        triggerTime = second;
    }
}