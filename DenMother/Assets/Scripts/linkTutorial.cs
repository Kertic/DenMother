﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class linkTutorial : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(543,543,false,60);
    }

    public void Changescene(string BrennanTestScene)
    {
        SceneManager.LoadScene(BrennanTestScene);
    }
}