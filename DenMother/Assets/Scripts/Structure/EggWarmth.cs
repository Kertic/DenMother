using System.Collections;
using System.Collections.Generic;
using Structure;
using UnityEngine;
using UnityEngine.UI;

public class EggWarmth : MonoBehaviour
{
    [SerializeField] private Image rune1;
    [SerializeField] private Image rune2;
    [SerializeField] private Image rune3;
    [SerializeField] private Image rune4;

    [SerializeField] private GameManager manager;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float rune1Alpha = 1.0f;
        float rune2Alpha = 1.0f;
        float rune3Alpha = 1.0f;
        float rune4Alpha = 1.0f;
        rune1Alpha = (manager.EggWarmth - 0.75f) * 4;
        rune2Alpha = (manager.EggWarmth - 0.5f) * 4;
        rune3Alpha = (manager.EggWarmth - 0.25f) * 4;
        rune4Alpha = (manager.EggWarmth) * 4;

        rune1.color = new Color(rune1.color.r, rune1.color.g, rune1.color.b, rune1Alpha);
        rune2.color = new Color(rune2.color.r, rune2.color.g, rune2.color.b, rune2Alpha);
        rune3.color = new Color(rune3.color.r, rune3.color.g, rune3.color.b, rune3Alpha);
        rune4.color = new Color(rune4.color.r, rune4.color.g, rune4.color.b, rune4Alpha);
    }
}