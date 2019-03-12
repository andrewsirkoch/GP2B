using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basketScript : MonoBehaviour
{
    private Vector3 mousePos;
    public bool control = false;
    public GameObject player;
    public AudioSource basketHit;

    public void enableControl()
    {
        control = true;
    }

    public void disableControl()
    {
        control = false;
    }
    private void Start()
    {
        player = GameObject.Find("player");
        basketHit = gameObject.GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (control == true)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector3(mousePos.x, -4, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("banana"))
        {
            player.GetComponent<Info>().score += 1;
            player.GetComponent<Info>().bananasCaught += 1;
            basketHit.pitch = Random.Range(1.6f, 2.0f);
            basketHit.Play();
        }
        else if (collision.gameObject.CompareTag("bananaBunch"))
        {
            player.GetComponent<Info>().score += 3;
            player.GetComponent<Info>().bunchesCaught += 1;
            basketHit.pitch = Random.Range(1.0f, 1.3f);
            basketHit.Play();
        }
        else if (collision.gameObject.CompareTag("poo"))
        {
            player.GetComponent<Info>().score -= 10;
            player.GetComponent<Info>().lives -= 1;
            player.GetComponent<Info>().poosCaught += 1;
            basketHit.pitch = Random.Range(0.3f, 0.5f);
            basketHit.Play();
        }
        else
        {
            player.GetComponent<Info>().score += 0;
        }
        Destroy(collision.gameObject);
    }
}
