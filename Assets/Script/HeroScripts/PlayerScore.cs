using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    Vector3 startPosition;
    [SerializeField] ParticleSystem crash;
    private int Score = 0;
    void Start() {
        startPosition = transform.position;
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstacle") {
            Score--;
            if (!crash.isPlaying) crash.Play();
            else crash.Stop();
            transform.position = startPosition;
            Debug.Log($"You Bumped! Total: {Score}");
        }
        if (other.gameObject.tag == "Star") {
            Score += 5;
            Debug.Log($"You take star! Total: {Score}");
        }
    }
}
