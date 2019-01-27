using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {
    public float healthBar;
    public float damage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetButton("Interact"))
        {
            healthBar -= damage;
        }
        if (healthBar <= 1E-6)
        {
            Destroy(gameObject);
            return;
        }
    }
}
