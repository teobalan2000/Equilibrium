using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleAudio : MonoBehaviour
{
    static SingleAudio instance;
    public GameObject audioOn;
    public GameObject audioOff;

    public void Start()
    {
        audioOff.SetActive(false);
        audioOn.SetActive(true);
    }

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void MuteAudio(bool mute)
    {
        if(mute)
        {
            AudioListener.volume = 0;
            audioOff.SetActive(true);
            audioOn.SetActive(false);
        }

        else
        {
            AudioListener.volume = 1;
            audioOff.SetActive(false);
            audioOn.SetActive(true);
        }
    }
}
