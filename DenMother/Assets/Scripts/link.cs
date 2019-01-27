using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class link : MonoBehaviour
{
    public void Changescene(string BrennanTestScene)
    {
        SceneManager.LoadScene(BrennanTestScene);
        if (Input.anyKeyDown)
            SceneManager.LoadScene("BrennanTestScene");

    }
    private void Update()
    {
        if (Input.anyKeyDown)
            SceneManager.LoadScene("BrennanTestScene");
    }
}