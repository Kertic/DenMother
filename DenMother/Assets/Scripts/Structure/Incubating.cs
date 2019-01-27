using System.Collections;
using System.Collections.Generic;
using Structure;
using UnityEngine;

public class Incubating : GameManager
{
    public float rate;
    // Use this for initialization
    void Start()
    {
        //Audio
        FindObjectOfType<AudioManager>().Play("Incubating");

    }

    // Update is called once per frame
    void Update()
    {
        EggWarmth += EggWarmth * rate * Time.deltaTime;
    }
}
