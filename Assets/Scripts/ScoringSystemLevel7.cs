using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoringSystemLevel7 : MonoBehaviour
{
    public GameObject scoreText;
    public int theScore = 5;
    public GameManager gameManager;
    public Transform target;
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
        float a = -1.2f;
        float b = -1.35f;
        theScore -= 1;
        TakeDamage(1);
        scoreText.GetComponent<Text>().text = "" + (theScore + 5);
        GameObject.Find("Ball").GetComponent<Movement>().enabled = true;
        GameObject.Find("Kale").GetComponent<kaleMovement>().speed = GameObject.Find("Kale").GetComponent<kaleMovement>().speed *a;
        GameObject.Find("Ball").GetComponent<Movement>().speed = GameObject.Find("Ball").GetComponent<Movement>().speed * b;

        if (theScore == -5)
        {
            FindObjectOfType<AudioManager>().Play("Bomb");
            oterizasyon.explode();
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




