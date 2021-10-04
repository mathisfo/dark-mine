using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveLeftRight;

    public float speed = 5;
    public float jumpForce = 7;

    void Move() {
        moveLeftRight = Input.GetAxis("Horizontal");
        if (moveLeftRight != 0) {
            rb.velocity = new Vector2(moveLeftRight
            *speed, rb.velocity.y);
        }
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y+jumpForce);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
}
