using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Link : MonoBehaviour 
{
    public void Changescene(string sceneName)
    {
        if (sceneName == "credits")
        {
            FindObjectOfType<AudioManager>().Play("CreditSong");
        }

        SceneManager.LoadScene(sceneName);
    }

}
