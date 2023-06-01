using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public int scoreValue = 10;

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Arrow") {
            // Increase the player's score by the score value of this target
            GameObject.FindGameObjectWithTag("Player").GetComponent<ScoringSystem>().AddScore(scoreValue);
            
            // Destroy this target
            Destroy(gameObject);
        }
    }
}


