﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 50)).x;

        _rigidbody.MovePosition(new Vector3(x, -17, 0));
    }
}
