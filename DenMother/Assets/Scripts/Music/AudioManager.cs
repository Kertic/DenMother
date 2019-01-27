using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections;

public class AudioManager : MonoBehaviour
{

    public sound[] Sound;

    public static AudioManager instance;

    // Use this for initialization
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
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

    //public void Play(string name)
    //{
    //    sound s = Array.Find(Sound, sound => sound.name == name);
    //    if (s == null)
    //    {
    //        Debug.LogWarning("Sound: "+name +"not found1!");
    //        return;
    //    }
    //    s.source.Play();
    //}

    public void Stop(string name)
    {
        sound s = Array.Find(Sound, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + "not found1!");
            return;
        }
        s.source.Stop();
    }

    public void Play(string name)
    {
        StopAllCoroutines();
        if (Sound != null) StartCoroutine(EndSound());

        sound s = Array.Find(Sound, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Music " + name + " not found.");
            return;
        }
        StartCoroutine(StartSound());
    }

    private IEnumerator EndSound()
    {
        AudioSource oldSound = Sound.source;
        while (oldSound.volume > 0)
        {
            oldSound.volume -= 0.01f;
            yield return null;
        }
        oldSound.Stop();
    }

    private IEnumerator StartSound()
    {
        Sound.source.Play();
        float volume = 0f;
        do
        {
            Sound.source.volume = volume;
            volume += 0.01f;
            yield return null;
        } while (Sound.source.volume <= Sound.volume);
    }
}
