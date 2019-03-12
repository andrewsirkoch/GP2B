using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetOnLoad : MonoBehaviour
{
    public GameObject player;

    void Awake()
    {
        // Reset player stats everytime this scene is loaded
        player = GameObject.Find("player");
        player.GetComponent<Info>().restart();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
