using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{

    private GameObject monkey;
    private GameObject basket;

    [Header("We will be listening for esc input in this script")]
    public GameObject UI;
    private bool paused = false;

    // Start is called before the first frame update
    void Start()
    {
        monkey = GameObject.Find("monkey");
        basket = GameObject.Find("basket");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && paused == false)
        {
            pause(true);
        }
        else if (Input.GetButtonDown("Cancel") && paused == true)
        {
            pause(false);
        }
    }

    public void pauseAllDroppables(bool decision)
    /// <summary>
    /// It would be unfair if objects continued to fall after pausing...
    /// So now we need to do this.
    /// Finds all droppables and merges them into mega array.
    /// Disables/Enables the rigid body on each object
    /// </summary>
    {
        GameObject[] bananas = GameObject.FindGameObjectsWithTag("banana");
        GameObject[] bunches = GameObject.FindGameObjectsWithTag("bananaBunch");
        GameObject[] poos = GameObject.FindGameObjectsWithTag("poo");
        GameObject[] allObjects = new GameObject[bananas.Length + bunches.Length + poos.Length];
        bananas.CopyTo(allObjects, 0);
        bunches.CopyTo(allObjects, bananas.Length);
        poos.CopyTo(allObjects, bananas.Length + bunches.Length);

        foreach (GameObject droppable in allObjects)
        {
            if (decision == true)
            {
                droppable.GetComponent<Rigidbody2D>().simulated = false;
            }
            else if (decision == false)
            {
                droppable.GetComponent<Rigidbody2D>().simulated = true;
            }

        }

    }

    public void pause(bool decision)
    /// <summary>
    /// Toggles the monkey movement, basket control,
    /// and calls pauseAllDroppables based on bool input.
    /// </summary>
    {
        if (decision == true)
        {
            monkey.GetComponent<monkeyMovement>().moving = false;
            basket.GetComponent<basketScript>().control = false;
            basket.GetComponent<Rigidbody2D>().simulated = false;
            UI.SetActive(true);
            pauseAllDroppables(true);
            paused = true;
            Cursor.visible = true;
        }
        else
        {
            monkey.GetComponent<monkeyMovement>().moving = true;
            basket.GetComponent<basketScript>().control = true;
            basket.GetComponent<Rigidbody2D>().simulated = true;
            UI.SetActive(false);
            pauseAllDroppables(false);
            paused = false;
            Cursor.visible = false;
        }

    }
}
