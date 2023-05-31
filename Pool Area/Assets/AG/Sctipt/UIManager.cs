using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // The singleton instance of the UIManager
    public static UIManager Instance;

    // The text element to display the player's score
    public Text scoreText;

    // The UI panel to display when the game is over
    public GameObject gameOverPanel;

    // The text element to display the player's final score
    public Text finalScoreText;

    // Initialize the singleton instance of the UIManager
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update the score text element to display the current score
    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Update the game over panel to display the final score
    public void UpdateGameOverPanel(int score)
    {
        finalScoreText.text = "Final Score: " + score.ToString();
        gameOverPanel.SetActive(true);
    }

    // Handle the player restarting the game
    public void RestartGame()
    {
        // TODO: Restart the game
    }
}