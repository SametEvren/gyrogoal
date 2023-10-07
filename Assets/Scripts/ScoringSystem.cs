﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore = 5;
    public GameManager gameManager;
    public Explotion oterizasyon;
    public CameraShake cameraShake;
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
        scoreText.GetComponent<Text>().text = "" + (theScore+5);
        GameObject.Find("Ball").GetComponent<Movement>().enabled = true;
        //var otherscript = GetComponent<Movement>();
        GameObject.Find("Ball").GetComponent<Movement>().speed = GameObject.Find("Ball").GetComponent<Movement>().speed + 1F;

        



        if (theScore == -1)
        {
            StartCoroutine(cameraShake.Shake(.15f, .4f));
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
