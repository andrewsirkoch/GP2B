using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeyMovement : MonoBehaviour
{
    [Header("Movement Control")]
    public bool moving = false;
    [Header("Sideways Speed")]
    public float speed;

    public Vector3 direction = new Vector3(1,0,0);
    [Header("Percentage chance to switch direction")]
    public float chance;

    [Header("Height of monkey")]
    public float height;

    public bool flippedRecently;
    [Range(0,60)]
    public int flippedRecentlyCounter;

    public void enableMovement()
    {
        moving = true;
    }

    public void disableMovement()
    {
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving == true)
        {
            if (flippedRecently == true && flippedRecentlyCounter <= 60) flippedRecentlyCounter += 1;
            if (flippedRecently == true && flippedRecentlyCounter > 60)
            {
                flippedRecentlyCounter = 0;
                flippedRecently = false;
            }
            if (Random.value <= chance || transform.position.x + (direction.x * speed * Time.deltaTime) >= 7  || transform.position.x - (direction.x * speed * Time.deltaTime) <= -7)
            {
                if (flippedRecently == false)
                {
                    direction *= -1;
                    flippedRecently = true;
                }
                
            }
            if (direction.x > 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            else if (direction.x <= 0)
            {
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            transform.position += direction * speed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, (Mathf.Pow(transform.position.x, 2)/40 + height), 0);
        }
    }
}
