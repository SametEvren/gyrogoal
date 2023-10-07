using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.name == "Duvar")
        {
            
            Destroy(GameObject.Find("Ball"));
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
