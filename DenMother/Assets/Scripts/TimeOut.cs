using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Structure;

public class GoOut : MonoBehaviour {
    public bool Comeback;

    public int storageHealth = FindObjectOfType<GameManager>().StorageHealth;
    public float requiredTime; //time require being outside to have +1 food

    private float timer;
    private float foodTimer;
    private float timeLeft;
    private float now;

    public float riskLevel;
    public float riskLevelRate;
    public float timeLimit = 1f;
    private int randomnNum;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame

    void Update()
    {
        //outside the den
        timer += Time.deltaTime;
        riskLevel += riskLevel * riskLevelRate * timer;
        foodTimer = timer;
        //increase storageHealth if outside for a period of time
        if (Mathf.Abs(foodTimer - requiredTime) <= 1E-6)
        {
            storageHealth += 1;
            foodTimer = 0;
        }

        //increase riskLevel if outside too long
        if (riskLevel >= timeLimit)
        {
            randomnNum = Random.Range(0, 10);
            if (randomnNum > 7)
            {
//                var snatcher : GameObject 
                //den damaged || storageHealth decreased
            }
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
