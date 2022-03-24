using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    [SerializeField] float yAngle;
    // просто разворачивает обьект.
    void Update()
    {
        transform.Rotate(0, yAngle, 0);
    }
}
