﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Movement
    public float speed = 6f;
    private Rigidbody2D rb;
    Vector2 movement;

    // Game Object References
    public GameObject msle;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update() {
        // Input
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        if (Input.GetKey("space")) {
            Instantiate(msle, transform.position, Quaternion.identity);
        }
    }

    void FixedUpdate() {
        //Movement
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
