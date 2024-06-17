using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpByButton : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpSpeed = 5;
    bool isGrounded;
    bool canDoublejump;
    public float delayBeforeDoublejump;
    [SerializeField] private Animator ani;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            ani.SetBool("Jump", false);
            isGrounded = true;
            canDoublejump = false;
        }
    }
    public void jumpButton()
    {
        
        if (isGrounded)
        {
            ani.SetBool("Jump", true);
            isGrounded = false;
            rb.velocity = Vector2.up * jumpSpeed;           
            Invoke("EnableDoubleJump", delayBeforeDoublejump);
        }
        if (canDoublejump)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            canDoublejump = false;
        }
    }
    void EnableDoubleJump()
    {
        canDoublejump = true;

    }
    private void FixedUpdate()
    {
       // rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
    }
}
