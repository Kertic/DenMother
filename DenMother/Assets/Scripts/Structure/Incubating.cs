using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Contextuals;
//using Structure.GameManager;

public class Incubating : MonoBehaviour {
    private bool collide;
    public ContextualParent myObject;

    private float rate;
    // Use this for initialization
    void Start () {
        myObject = GameObject.FindObjectOfType<ContextualParent>;
    }

    // Update is called once per frame
    void Update () {
        ContextualParent.AreTwoRectsColliding()
        if (collide)
        {
            eggwarm += eggwarm * rate;
        }

    }
}
