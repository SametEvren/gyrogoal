using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystemLevel5 : MonoBehaviour
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
        float a = -1.2F;
        theScore -= 1;
        //scoreText.GetComponent<Text>().text = "SCORE:" + theScore;
        scoreText.GetComponent<Text>().text = "" + (theScore + 5);
        GameObject.Find("Ball").GetComponent<Movement>().enabled = true;
        //var otherscript = GetComponent<Movement>();
        
        GameObject.Find("Ball").GetComponent<Movement>().speed = GameObject.Find("Ball").GetComponent<Movement>().speed * a;
        
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






