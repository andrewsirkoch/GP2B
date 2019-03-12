using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class updateAudio : MonoBehaviour
{
    private GameObject BugNoises;
    // Start is called before the first frame update
    void Start()
    {
        BugNoises = GameObject.Find("BugNoises");
        BugNoises.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volumeSfx");
    }
}
