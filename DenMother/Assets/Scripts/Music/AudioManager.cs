using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class AudioManager : MonoBehaviour
{
    private static bool keepFadeIn;
    private static bool keepFadeOut;

    public sound[] Sound;

    public static AudioManager instance;

    // Use this for initialization
    void Awake()
    {
        //if (instance == null)
        //{
        //    instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        instance = this;
        DontDestroyOnLoad(gameObject);

        foreach (sound s in Sound)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;

            s.source.loop = s.loop;
        }
    }

    public void Start()
    {
        Play("Theme");
    }

    public void Stop(string name)
    {
        sound s = Array.Find(Sound, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Stop();
    }

    public void Play(string name)
    {
        sound s = Array.Find(Sound, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found!");
            return;
        }
        s.source.Play();
    }

    //public void Play(string name)
    //{
    //    float speed = 0.01f;
    //    //StopAllCoroutines();
    //    if (Sound != null)
    //    {
    //        StartCoroutine(FadeOut(Sound[0], speed));
    //    }

    //    sound s = Array.Find(Sound, sound => sound.name == name);
    //    if (s == null)
    //    {
    //        Debug.LogWarning("Sound: " + name + " not found!");
    //        return;
    //    }
    //    StartCoroutine(FadeIn(s,speed));
    //}

    private IEnumerator FadeOut(sound s,float speed)
    {
        keepFadeIn = false;
        keepFadeOut = true;
        float audioVolume = s.source.volume;

        while (s.source.volume >= speed && keepFadeOut)
        {
            audioVolume -= speed;
            s.source.volume = audioVolume; 
            yield return new WaitForSeconds(0.1f);
        }
    }

    private IEnumerator FadeIn(sound s, float speed, float maxVolume = 3)
    {
        keepFadeIn = true;
        keepFadeOut = false;
        s.source.volume = 0;
        float audioVolume = s.source.volume;

        while (s.source.volume <maxVolume && keepFadeIn)
        {
            audioVolume += speed;
            s.source.volume = audioVolume;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
