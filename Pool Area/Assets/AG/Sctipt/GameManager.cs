using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Static reference to the GameManager instance
    public static GameManager instance;

    // Player's current score
    private int score = 0;

    // Reference to the UI manager
    private UIManager uiManager;

    // Called when the script instance is being loaded
    private void Awake()
    {
        // Set the instance reference to this object
        instance = this;
    }

    // Called when the script instance is being destroyed
    private void OnDestroy()
    {
        // Clear the instance reference
        instance = null;
    }

    // Called when the game starts
    private void Start()
    {
        // Get a reference to the UI manager
        uiManager = FindObjectOfType<UIManager>();
    }

    // Add points to the player's score
    public void AddScore(int points)
    {
        score += points;

        // Update the UI to display the new score
        uiManager.UpdateScore(score);
    }

    // Reset the game state
    public void ResetGame()
    {
        // Reset the score
        score = 0;

        // Update the UI to display the new score
        uiManager.UpdateScore(score);

        // Reset any other game state here...
    }
}
