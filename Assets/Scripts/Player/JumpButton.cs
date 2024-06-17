using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpButton : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Rigidbody2D rig2D;
    [SerializeField] private Animator animator;
    private const string IsJumpingParamName = "Jump";
    private bool jump;
    public float jumpForce;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool ground;
    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }
    public void PointerDownJump()
    {
        jump = true;
    }
    public void PointerUpJump()
    {
        jump = false;
    }


    // Update is called once per frame
    void Update()
    {
        if (jump)
        {
            Jump();
        }
    }
    private void Jump()
    {
        animator.SetBool(IsJumpingParamName, true);
        if (ground)
        {
            rig2D.velocity = new Vector2(rig2D.velocity.x, jumpForce);
            ground = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            animator.SetBool(IsJumpingParamName, false);
            ground = true;
        }
    }
}
