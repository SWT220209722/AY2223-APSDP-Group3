using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcheryTarget : MonoBehaviour
{
    // Score for hitting this target
    public int scoreValue = 10;

    // Sound effect to play when hit
    public AudioClip hitSound;

    // Particle effect to spawn when hit
    public GameObject hitParticles;

    // Detect when an arrow collides with the target
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that collided with the target is an arrow
        if (collision.gameObject.tag == "Arrow")
        {
            // Update the score
            GameManager.instance.AddScore(scoreValue);

            // Play hit sound effect
            AudioSource.PlayClipAtPoint(hitSound, transform.position);

            // Spawn hit particle effect
            Instantiate(hitParticles, transform.position, Quaternion.identity);

            // Destroy the arrow
            Destroy(collision.gameObject);
        }
    }
}
