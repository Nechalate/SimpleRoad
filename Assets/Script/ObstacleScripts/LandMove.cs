using UnityEngine;

public class LandMove : MonoBehaviour
{
    public GameObject trigger;
    [SerializeField] float speedStart;
    [SerializeField] float speedBack;
    private float distance;
    void Update()
    {
        if (trigger.gameObject.tag == "Hit") {
            MoveChoose(speedStart, speedBack);
        }
    }
    // высчитываем сколько будет прибавляться к дистанции каждый кадр.
    void FixedUpdate() {
        distance += 0.0135f;
    }
    // метод отвечает за волнообразные движения обьектов из точки A в точку Б.
    void MoveChoose(float speedNow, float speedBack) {
        if (distance > 2) {
            transform.Translate(new Vector3(speedBack, 0, 0) * Time.deltaTime);
            if (distance > 4) distance = 0;
        }
        else transform.Translate(new Vector3(speedNow, 0, 0) * Time.deltaTime);
    }
}
