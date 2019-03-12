using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showHighScores : MonoBehaviour
{
    private Text textBlock;
    private string highScores = "";

    // Start is called before the first frame update
    void Update()
    {
        textBlock = gameObject.GetComponent<Text>();
        for (int i = 1; i <= 10; i++)
        {
            highScores = highScores + i.ToString() + ": " + PlayerPrefs.GetInt("Highscore" + i.ToString()) + "\r\n";
        }
        textBlock.text = highScores;
    }

}
