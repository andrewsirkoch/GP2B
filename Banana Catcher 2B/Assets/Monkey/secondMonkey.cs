using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondMonkey : MonoBehaviour
{
    [Header("Time before second monkey comes into screen in frames. (sec * 50)")]
    public int waitTime;

    private bool startMoving;
    private bool onScreen;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pauseMenu.paused == false && onScreen == false)
        {
            waitTime -= 1;
        }
        if (waitTime <= 0 && pauseMenu.paused == false && onScreen == false)
        {
            enable();
        }
        if (startMoving == true && onScreen == false)
        {
            transform.position += gameObject.GetComponent<monkeyMovement>().direction * gameObject.GetComponent<monkeyMovement>().speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, (Mathf.Pow(transform.position.x, 2) / 40 + 1.5f), 0);
            if (transform.position.x <= 5)
            {
                onScreen = true;
                gameObject.GetComponent<monkeyMovement>().moving = true;
                gameObject.GetComponent<monkeyThrow>().enabled = true;
            }
        }
    }
    public void enable()
    {
        startMoving = true;
        gameObject.GetComponent<monkeyMovement>().direction = new Vector3 (-1,0,0);

    }
}
