using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interacts : MonoBehaviour {
    public bool interact;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        interact = Input.GetButtonDown("Interact");
		if (interact) { }
    }
}
