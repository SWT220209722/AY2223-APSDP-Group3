using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public void UpdateScore(Point arrowPosition, Point targetCenter)
{
    // Calculate the distance between the arrow position and the target center
    double distance = CalculateDistance(arrowPosition, targetCenter);
    
    // Determine which circle the arrow hit based on the distance
    int score;
    if (distance <= innerCircleRadius)
    {
        score = 10;
    }
    else if (distance <= secondCircleRadius)
    {
        score = 9;
    }
    else if (distance <= thirdCircleRadius)
    {
        score = 8;
    }
    else if (distance <= fourthCircleRadius)
    {
        score = 7;
    }
    else if (distance <= fifthCircleRadius)
    {
        score = 6;
    }
    else if (distance <= sixthCircleRadius)
    {
        score = 5;
    }
    else if (distance <= seventhCircleRadius)
    {
        score = 4;
    }
    else if (distance <= eighthCircleRadius)
    {
        score = 3;
    }
    else if (distance <= ninthCircleRadius)
    {
        score = 2;
    }
    else
    {
        score = 1;
    }
    // Update the player's score
    playerScore += score;
}