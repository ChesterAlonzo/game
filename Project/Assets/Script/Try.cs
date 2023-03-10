using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Try : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    private float speed = 8f;
private void Awake()
{
    body = GetComponent<Rigidbody2D>();
    anim = GetComponent<Animator>();
}

private void Update()
{
    float horizontalInput = Input.GetAxis("Horizontal");
    body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

    if (horizontalInput > 0.01f)
        transform.localScale = Vector3.one;
    else if (horizontalInput < -0.01f)
        transform.localScale = new Vector3(-1,1,1);
    
    if (Input.GetKey(KeyCode.Space))
        body.velocity = new Vector2(body.velocity.x, speed);

    anim.SetBool("run", horizontalInput !=0);
}
}
