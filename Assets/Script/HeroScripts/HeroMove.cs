using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] int instructionChoose;
    // Start is called before the first frame update
    void Start()
    {
        Instructions(instructionChoose);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();
    }

    void Instructions(int num) {
        if (num == 1) {
            Debug.Log("Player movement WASD");
        }
        else Debug.Log($"Move Speed - {moveSpeed}");
    }

    void PlayerMovement() {
        float speedX = Input.GetAxis("Horizontal") * moveSpeed;
        float speedZ = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3 (speedX, 0, speedZ) * Time.deltaTime);
    }
}
