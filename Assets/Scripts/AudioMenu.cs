using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    public float volume = 100f;
    public float reduceVolume = 20f;
    private void Start()
    {
        volume = PlayerPrefs.GetFloat("Volume", volume);
        Debug.Log(PlayerPrefs.GetFloat("Volume", volume));
        volume -= reduceVolume;
        PlayerPrefs.SetFloat("Volume", volume);
        Debug.Log(PlayerPrefs.GetFloat("Volume", volume));
    }
}
