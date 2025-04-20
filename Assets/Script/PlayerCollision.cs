using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private GameManager gameManager;
    private AudioManager audioManager;

    private void Awake()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        audioManager = FindAnyObjectByType<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            audioManager.PlayCoin();
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
        
        if (other.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            gameManager.GameWin();
        }
    }
}
