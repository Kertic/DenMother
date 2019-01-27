using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Structure;

public class TimeOut : MonoBehaviour {
    public bool Comeback;
    public int storageHealth = FindObjectOfType<GameManager>().storageHealth;
    public float requiredTime; //time require being outside to have +1 food

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    private float timer;
    private float foodTimer;
    private float timeLeft;
    private float now;

    void Update()
    {
        //outside the den
        timer += Time.deltaTime;
        foodTimer = timer;
        //increase storageHealth if outside for a period of time
        if (Mathf.Abs(foodTimer - requiredTime) <= 1E-6)
        {
            storageHealth += 1;
            foodTimer = 0;
        }

        Comeback = Input.GetButtonDown("Interact"); //press e to comeback
        if (Comeback)
        {
            now = timer;
            timer = 0;
            this.CountDown(now);
        }
    }
    protected void CountDown(float now)
    {
        timeLeft = now;
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0) 
        {/*arrive den*/
            return;
        }
    }

}
