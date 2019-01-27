using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeasonalDials : MonoBehaviour {
    public float seasonDuration;
    private float timer;
    private int index = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        while (index < 4)
        {
            //start the timer
            timer += Time.deltaTime;

            switch (index)
            {
                case 0: //spring
                    FindObjectOfType<AudioManager>().Play("spring");//music
                    break;
                case 1: //summer
                    FindObjectOfType<AudioManager>().Play("spring");//music
                    break;
                case 2: //fall
                    FindObjectOfType<AudioManager>().Play("winter");//music
                    break;
                default: //winter
                    FindObjectOfType<AudioManager>().Play("winter");//music
                    break;
            }

            //end of season
            if (timer >= seasonDuration)
            {
                //next season
                index += 1;
                timer = 0;
            }
        }
        //FINISH LEVEL

        //play credit screen
        FindObjectOfType<link2>().Changescene("credits");
        return;
    }
}
