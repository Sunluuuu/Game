using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    public Vector2 moveVector;
    public bool faceRight = true;

    private void Update()
    {
        Run();
        Reflect();
    }
    void Run()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);

        moveVector.y = Input.GetAxis("Vertical");
        anim.SetFloat("moveY", Mathf.Abs(moveVector.y));
        rb.velocity = new Vector2(rb.velocity.x, moveVector.y * speed);
    }
    void Reflect()
    {
        if((moveVector.x>0 && !faceRight)||(moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }
}
