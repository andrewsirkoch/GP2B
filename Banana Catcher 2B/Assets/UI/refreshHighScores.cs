using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class refreshHighScores : MonoBehaviour
{
    List<int> HighScores = new List<int>();
    private GameObject player;

    void Awake()
    {
        player = GameObject.Find("player");

        for (int i = 0; i <= 9; i++)
        {
            HighScores.Add(PlayerPrefs.GetInt("Highscore" + (i + 1).ToString()));
        }
        if (player.GetComponent<Info>().score > HighScores[9])
        {
            HighScores.Add(player.GetComponent<Info>().score);
            HighScores.Sort();
            HighScores.Reverse();
            for (int i = 0; i <= 9; i++)
            {
                PlayerPrefs.SetInt("Highscore" + (i + 1).ToString(), HighScores[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
