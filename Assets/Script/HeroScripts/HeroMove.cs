using UnityEngine;

public class HeroMove : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] int instructionChoose;
    // в старте запускает метод инструкции (обучение) чтобы оно вывелось в начале запуска игры один раз.
    void Start()
    {
        Instructions(instructionChoose);
    }
    // в update запускаем передвижение т.к метод будет обрабатыватся каждый кадр.
    void Update()
    {
        PlayerMovement();
    }
    // простое обучение в консоли.
    void Instructions(int num) {
        if (num == 1) {
            Debug.Log("Player movement WASD");
        }
        else Debug.Log($"Move Speed - {moveSpeed}");
    }
    // передвижение игрока.
    void PlayerMovement() {
        float speedX = Input.GetAxis("Horizontal") * moveSpeed;
        float speedZ = Input.GetAxis("Vertical") * moveSpeed;
        transform.Translate(new Vector3 (speedX, 0, speedZ) * Time.deltaTime);
    }
}
