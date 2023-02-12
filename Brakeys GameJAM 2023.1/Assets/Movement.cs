using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movement;
    public float speed;
    public float jumpforce;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(movement * speed, 0);
    }
}
