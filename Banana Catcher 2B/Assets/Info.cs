using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Info : MonoBehaviour
{
    [Header("Player Statistics for current game")]
    public int score = 0;
    public int lives = 3;
    public int bananasCaught = 0;
    public int bunchesCaught = 0;
    public int poosCaught = 0;

    private bool lost = false;

    public void restart()
    {
        score = 0;
        lives = 3;
        bananasCaught = 0;
        bunchesCaught = 0;
        poosCaught = 0;
        lost = false;
    }

    public void Awake()
    {
        // This is so the object does not get destroyed when we go to the lose screen.
        // We still need to access player stats in the lose screen, for highscore purposes.

        DontDestroyOnLoad(this.gameObject);

        for (int i = 1; i <= 10; i++)
        {
            if (!PlayerPrefs.HasKey("Highscore" + i.ToString()))
            {
                PlayerPrefs.SetInt("Highscore" + i.ToString(), 0);
            }
        }
        if (!PlayerPrefs.HasKey("volumeMusic"))
        {
            PlayerPrefs.SetFloat("volumeMusic", 1.0f);
        }
        if (!PlayerPrefs.HasKey("volumeSfx"))
        {
            PlayerPrefs.SetFloat("volumeSfx", 1.0f);
        }
        
    }

    public void Update()
    {
        // Listen for losing conditions.
        if (lives <= 0 && lost == false)
        {
            lost = true;
            SceneManager.LoadScene(3);
            Cursor.visible = true;
        }
    }
}
