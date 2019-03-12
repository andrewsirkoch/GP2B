using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bottomCheck : MonoBehaviour
{
    public GameObject player;
    private void Start()
    {
        player = GameObject.Find("player");
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("banana"))
        {
            player.GetComponent<Info>().lives -= 1;
        }
        else if (collision.gameObject.CompareTag("bananaBunch"))
        {
            player.GetComponent<Info>().lives -= 1;
        }
        else if (collision.gameObject.CompareTag("poo"))
        {
            player.GetComponent<Info>().lives += 1;
        }
        else
        {
            player.GetComponent<Info>().lives += 0;
        }
        Destroy(collision.gameObject);
    }
}
