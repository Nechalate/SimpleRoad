using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    Vector3 startPosition;
    [SerializeField] ParticleSystem crash;
    [SerializeField] Text _scoreNumber;
    Text score;
    private int Score = 0;
    void Start() {
        startPosition = transform.position;
        score = _scoreNumber.GetComponent<Text>();
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstacle") {
            Score--;
            if (!crash.isPlaying) crash.Play();
            else crash.Stop();
            transform.position = startPosition;
            score.text = Score.ToString();
            Debug.Log($"You Bumped! Total: {Score}");
        }
        if (other.gameObject.tag == "Star") {
            Score += 5;
            score.text = Score.ToString();
            Debug.Log($"You take star! Total: {Score}");
        }
    }
}
