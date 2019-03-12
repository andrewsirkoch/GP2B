using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour
{
    private int score;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        score = player.GetComponent<Info>().score;
        gameObject.GetComponent<Text>().text = $"Score: {score}";
    }

    // Update is called once per frame
    void Update()
    {
        score = player.GetComponent<Info>().score;
        gameObject.GetComponent<Text>().text = $"Score: {score}";
    }
}
