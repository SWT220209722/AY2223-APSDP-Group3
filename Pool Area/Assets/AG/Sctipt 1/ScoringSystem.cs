using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour {
    public int score= 0;
    //public static Text P1scoreText;
    
    public void AddScore(int points) {
        score += points;
        Debug.Log("Score  " + score);
        //P1scoreText.text= "Score: ";
    }
}
