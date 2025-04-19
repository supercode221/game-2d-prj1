using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            gameManager.AddScore(1);
        }

        if (other.CompareTag("Trap"))
        {
            gameManager.GameOver();
        }

        if (other.CompareTag("Enemy"))
        {
            gameManager.GameOver();
        }
    }
}
