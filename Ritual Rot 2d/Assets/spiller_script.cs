using System.Numerics;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class spiller_script : MonoBehaviour
{
    public float moveSpeed = 5f;
    float horizontal;
    float vertical;
    private Rigidbody2D rb;


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
    }
}
