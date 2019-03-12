using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadSoundPreferences : MonoBehaviour
{
    private GameObject pooSound;
    private GameObject m1;
    private GameObject m2;
    private GameObject m3;
    private GameObject basket;
    private GameObject background;

    void Awake()
    {
        pooSound = GameObject.Find("pooSound");
        m1 = GameObject.Find("m1");
        m2 = GameObject.Find("m2");
        m3 = GameObject.Find("m3");
        basket = GameObject.Find("basket");
        background = GameObject.Find("Background");

        float musicVolume = PlayerPrefs.GetFloat("volumeMusic");
        float fullVolume = PlayerPrefs.GetFloat("volumeSfx");
        float halfVolume = 0.5f * PlayerPrefs.GetFloat("volumeSfx");
        float thirdVolume = 0.75f * PlayerPrefs.GetFloat("volumeSfx");
        float quarterVolume = 0.25f * PlayerPrefs.GetFloat("volumeSfx");

        AudioSource pooAudio = pooSound.GetComponent<AudioSource>();
        AudioSource m1Audio = m1.GetComponent<AudioSource>();
        AudioSource m2Audio = m2.GetComponent<AudioSource>();
        AudioSource m3Audio = m3.GetComponent<AudioSource>();
        AudioSource basketAudio = basket.GetComponent<AudioSource>();
        AudioSource musicAudio = background.GetComponent<AudioSource>();

        pooAudio.volume = quarterVolume;
        m1Audio.volume = thirdVolume;
        m2Audio.volume = thirdVolume;
        m3Audio.volume = thirdVolume;
        basketAudio.volume = halfVolume;
        musicAudio.volume = musicVolume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
