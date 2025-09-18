using System.Numerics;
using NUnit.Framework;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class spiller_script : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isGround;
    public int facingDirection = 1;
    private Rigidbody2D rb;
    public Animator anim;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new UnityEngine.Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        if (Input.GetButtonDown("Jump") && isGround)
        {
            rb.linearVelocity = new UnityEngine.Vector2(rb.linearVelocityX, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        } 
    }

    //Bruges til at kalde animationen
    void FixedUpdate()
    {
        float horizontal= Input.GetAxis("Horizontal");

        if(horizontal > 0 && transform.localScale.x < 0|| horizontal < 0 && transform.localScale.x > 0)
        {
            Flip();
        }
       

        anim.SetFloat("horizontal", Mathf.Abs(horizontal));
      
    }

    void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new UnityEngine.Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
    }

}
 
