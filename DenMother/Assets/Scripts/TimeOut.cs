using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOut : MonoBehaviour {
    public bool Comeback;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    private float timer;
    private float timeLeft;
    private float now;

    void Update()
    {
        timer += Time.deltaTime;
        Comeback = Input.GetKeyDown(KeyCode.b); //press b to comeback

        if (Comeback)
        {
            now = timer;
            this.CountDown(now);
        }
    }
    protected void CountDown(float now)
    {
        timeLeft = now;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0) 
        {/*arrive den*/}
    }

}
