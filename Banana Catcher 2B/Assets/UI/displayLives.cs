using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayLives : MonoBehaviour
{
    private int lives;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        lives = player.GetComponent<Info>().lives;
        gameObject.GetComponent<Text>().text = $"Lives: {lives}";
    }

    // Update is called once per frame
    void Update()
    {
        lives = player.GetComponent<Info>().lives;
        gameObject.GetComponent<Text>().text = $"Lives: {lives}";
    }
}
