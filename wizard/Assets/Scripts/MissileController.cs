using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour {
    
    // Variables
    private Vector3 mousePos;
    private Vector2 direction;
    private Rigidbody2D rb;

    // Traits
    public float speed = 1f;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        direction = (mousePos - transform.position).normalized;
    }

    void FixedUpdate() {
        if (Input.GetMouseButton(0)) {
            rb.velocity = new Vector2(direction.x * speed, direction.y * speed);
        } else {
            rb.velocity = Vector2.zero;
        }
    }
}