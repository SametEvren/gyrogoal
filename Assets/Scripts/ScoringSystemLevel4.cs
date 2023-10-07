﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystemLevel4 : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore = 5;
    public GameManager gameManager;
    public Explotion oterizasyon;

    public int maxHealth = 5;
    public int currentHealth;

    public healthbar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        TakeDamage(1);
        theScore -= 1;
        //scoreText.GetComponent<Text>().text = "SCORE:" + theScore;
        scoreText.GetComponent<Text>().text = "" + (theScore + 5);
        GameObject.Find("Ball").GetComponent<Movement>().enabled = true;
        //var otherscript = GetComponent<Movement>();
        GameObject.Find("Ball").GetComponent<Movement>().width = GameObject.Find("Ball").GetComponent<Movement>().width + 0.5F;
        GameObject.Find("Ball").GetComponent<Movement>().height = GameObject.Find("Ball").GetComponent<Movement>().height + 0.5F;
        GameObject.Find("Ball").GetComponent<Movement>().speed = GameObject.Find("Ball").GetComponent<Movement>().speed + 1F;
        GameObject.Find("Sphere").transform.localScale += new Vector3(1.0F, 0, 1.0F);
        if (theScore == -5)
        {
            oterizasyon.explode();
            FindObjectOfType<AudioManager>().Play("Bomb");
            Invoke("FinishGame", 3f);
        }

    }
    void FinishGame()
    {
        gameManager.CompleteLevel();
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}


    


