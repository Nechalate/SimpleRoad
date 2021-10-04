﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody rigidBody;
    [SerializeField] float time;
    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        render.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > time) {
            render.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
