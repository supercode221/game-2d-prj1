using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private GameObject gameOverUI;
    private bool isGameOver = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        UpdateScore();
        gameOverUI.SetActive(false);
    }

    public void AddScore(int points)
    {
        if(isGameOver) return;
        score += points;
        UpdateScore();
    }

    private void UpdateScore()
    {
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        isGameOver = true;
        score = 0;
        
        //De cho nguoi choi khong bam duoc phim gi nua
        Time.timeScale = 0;
        
        gameOverUI.SetActive(true);
    }

    public void RestartGame()
    {
        isGameOver = false;
        score = 0;
        UpdateScore();
        Time.timeScale = 1;
        SceneManager.LoadScene("Game");
    }
    
    public bool IsGameOver()
    {
        return isGameOver;
    }
}
