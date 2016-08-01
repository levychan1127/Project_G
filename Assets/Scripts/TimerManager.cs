﻿using UnityEngine;
using System.Collections;

public class TimerManager : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //If u have many timer 
        //u also can serval frame call one time to save some performance, but the deltaTime u should calculate youself
        //like :(u should define lastTime youself-- float)

        /*
		if(Time.frameCount%5 == 0)
		{
			delta = Time.time - lastTime;
			test.Update(Time.deltaTime);
			lastTime = Time.time;
		}
		*/
	ArrayList tempList = Timer.timerList;
        foreach(Timer t in arrayList)
        {
            if (t.isTicking)
            {
                t.curTime += Time.deltaTime;

                if (t.curTime > t.triggerTime)
                {
                    t.isTicking = false;
                    t.End();
                    Timer.timerList.Remove(this);
                    //break;
                }
            }
        }
    }

    //Some time u may need this to avoid conflict when re-init something , just a tip .
    void OnDestory()
    {

    }

}
