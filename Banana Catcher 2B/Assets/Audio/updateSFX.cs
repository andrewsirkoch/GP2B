using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateSFX : MonoBehaviour
{
    public GameObject sfxSlider;
    public GameObject musicSlider;
    public GameObject bugNoises;

    private void Awake()
    {
        bugNoises = GameObject.Find("BugNoises");

        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volumeMusic");
        sfxSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volumeSfx");
    }
    // Update is called once per frame
    void Update()
    {
        bugNoises.GetComponent<AudioSource>().volume = sfxSlider.GetComponent<Slider>().value;
    }
}
