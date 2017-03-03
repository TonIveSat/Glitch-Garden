using System;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    static MusicManager instance;

    public AudioClip[] LevelMusicChangeArray;

    private AudioSource musicAudioSource;

    void Awake()
    {
        if (instance == null || instance == this)
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
            musicAudioSource = GetComponent<AudioSource>();
            musicAudioSource.volume = PlayerPrefsManager.GetMasterVolume();
            musicAudioSource.loop = false;
        }
        else
        {
            GameObject.Destroy(gameObject);
        }
    }

    public void ChangeVolume(float volume)
    {
        musicAudioSource.volume = volume;
    }

    // Use this for initialization
    void Start ()
    {
        musicAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}

    public void OnLevelWasLoaded(int level)
    {
        Debug.Log("MusicManager level loaded: " + level);
        musicAudioSource.Stop();
        var audioClip = LevelMusicChangeArray[level];
        if (audioClip)
        {
            musicAudioSource.clip = audioClip;
            musicAudioSource.loop = true;
            musicAudioSource.Play();
        }
    }
}
