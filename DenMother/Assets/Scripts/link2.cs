using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class link : MonoBehaviour
{

    public void Changescene(string BrennanTestScene)
    {
        Application.LoadLevel(BrennanTestScene);
    }
}
