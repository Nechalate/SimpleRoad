using UnityEngine;

public class LandslideTrigger : MonoBehaviour
{
    // меняет тег на "удар" после того как коллизия игрока соприкоснулась с объектом.
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player") {
            gameObject.tag = "Hit";
        }
    }
}
