using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonFunctions : MonoBehaviour
{
    public GameObject musicSlider;
    public GameObject sfxSlider;

    private GameObject bugNoises;

    public void Awake()
    {
        bugNoises = GameObject.Find("BugNoises");
    }
    public void ExitApplication()
    {
        Application.Quit();
    }

    public void hideCursor()
    {
        Cursor.visible = false;
    }
    public void showCursor()
    {
        Cursor.visible = true;
    }

    public void loadGame()
    {
        SceneManager.LoadScene(2);
    }

    public void refreshPreferences()
    {
        musicSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volumeMusic");
        sfxSlider.GetComponent<Slider>().value = PlayerPrefs.GetFloat("volumeSfx");
    }

    public void savePreferences()
    {
        PlayerPrefs.SetFloat("volumeMusic", musicSlider.GetComponent<Slider>().value);
        PlayerPrefs.SetFloat("volumeSfx", sfxSlider.GetComponent<Slider>().value);
    }

    public void applySfx()
    {
        bugNoises.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volumeSfx");
    }
}
