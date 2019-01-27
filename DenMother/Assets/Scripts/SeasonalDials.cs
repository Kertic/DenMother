using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonalDials : MonoBehaviour {
    private float timeOfSeason;
    private float timer;
    string[] season = { "Spring", "Summer", "Fall","Winter"};
    private int index = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        while (true)
        {
            //start the timer
            timer += Time.deltaTime;

            if (index == 0)
            {//spring
            }
            else if (index ==1)
            { //summer
            }
            else if (index ===2)
            { //fall
            }
            else 
            { //winter
            }

            //end of season
            if (timer == timeOfSeason)
            {
                //next season
                index += 1;

                //reset season
                if (index > 4)
                {
                    index = 0;
                }
                timer = 0;
                continue;
            }

        }
    }
}
