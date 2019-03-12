using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monkeyThrow : MonoBehaviour
{
    [Header("Sprite in which the hands are receded")]
    public Sprite notThrowing;

    [Header("Sprite in which the hands are extended")]
    public Sprite throwing;

    private bool doneThrowing;
    private int animationCounter = 0;
    private int throwCounter = 0;
    public int timer = 70;

    private AudioSource soundOne;
    private AudioSource soundTwo;
    private AudioSource soundThree;
    private AudioSource fartSound;

    private void Start()
    {
        soundOne = GameObject.Find("m1").GetComponent<AudioSource>();
        soundTwo = GameObject.Find("m2").GetComponent<AudioSource>();
        soundThree = GameObject.Find("m3").GetComponent<AudioSource>();
        fartSound = GameObject.Find("pooSound").GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void dropSomething()
    {
        float decision = Random.value;

        if (decision < 0.15)
        {
            Instantiate(Resources.Load("Droppables/bananaBunch"));

            int random = Random.Range(0, 3);
            if (random == 0) soundOne.Play();
            else if (random == 1) soundTwo.Play();
            else if (random == 2) soundThree.Play();
        }
        else if (decision >= 0.15 && decision <= 0.9)
        {
            Instantiate(Resources.Load("Droppables/banana"));
        }
        else if (decision > 0.9)
        {
            Instantiate(Resources.Load("Droppables/poo"));
            fartSound.pitch = Random.Range(0.75f, 0.9f);
            fartSound.Play();
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (gameObject.GetComponent<monkeyMovement>().moving == true)
        {
            throwCounter += 1;
            if (throwCounter >= timer)
            {
                doneThrowing = false;

                dropSomething();

                gameObject.GetComponent<SpriteRenderer>().sprite = throwing;
                throwCounter = 0;

                if (timer - 1 >= 18)
                {
                    timer -= 1;
                }
            }
            if (doneThrowing == false && animationCounter <= 15)
            {
                animationCounter += 1;
            }
            else if (doneThrowing == false && animationCounter > 15)
            {
                doneThrowing = true;
                animationCounter = 0;
            }
            if (doneThrowing == true)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = notThrowing;
            }
        }
    }
}
