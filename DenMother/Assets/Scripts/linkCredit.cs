using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class linkCredit : MonoBehaviour
{

    public void Changescene(string BrennanTestScene)
    {
        FindObjectOfType<AudioManager>().Play("CreditSong");

        SceneManager.LoadScene("Credit");
    }
}
