using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandMove : MonoBehaviour
{
    public GameObject trigger;
    [SerializeField] float speedStart;
    [SerializeField] float speedBack;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger.gameObject.tag == "Hit") {
            MoveChoose(speedStart, speedBack);
        }
    }

    void FixedUpdate() {
        distance += 0.0135f;
    }

    void MoveChoose(float speedNow, float speedBack) {
        if (distance > 2) {
            transform.Translate(new Vector3(speedBack, 0, 0) * Time.deltaTime);
            if (distance > 4) distance = 0;
        }
        else transform.Translate(new Vector3(speedNow, 0, 0) * Time.deltaTime);
    }
}
