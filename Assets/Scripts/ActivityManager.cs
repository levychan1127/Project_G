using UnityEngine;
using System.Collections;

public class ActivityManager : MonoBehaviour {

    public Activity test;

    // Use this for initialization
    void Start () {
        test = new Activity(10.0f, 1.0f);
        test.ActivityStart();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
