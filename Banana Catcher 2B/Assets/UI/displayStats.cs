using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayStats : MonoBehaviour
{
    private int bananas;
    private int bunches;
    private int poos;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        bananas = player.GetComponent<Info>().bananasCaught;
        bunches = player.GetComponent<Info>().bunchesCaught;
        poos = player.GetComponent<Info>().poosCaught;
        gameObject.GetComponent<Text>().text = $"Bananas Caught: {bananas} (" + bananas + $" pts)\r\nBunches Caught: {bunches} (" + bunches * 3 + $" pts)\r\nPoos Caught: {poos} (" + poos * -10 + " pts)";
    }
}
