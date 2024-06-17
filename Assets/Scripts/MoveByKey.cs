using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByKey : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Rigidbody2D rig2D;
    [SerializeField]private Animator animator;
    private const string IsWalkingParamName = "Walk";
    public float speed;
    private float horizontalMove;
    private bool moveRight;
    private bool moveLeft;
    bool facingRight;

    void Start()
    {
        rig2D = GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    
    public void pointerDownLeft()
    {
        moveLeft = true;
    }
    public void pointerUpLeft()
    {
        moveLeft = false;
    }
    public void pointerDownRight()
    {
        moveRight = true;
    }
    public void pointerUpRight()
    {
        moveRight = false;
    }
    void Movement()
    {
        if (moveLeft)
        {
            horizontalMove = -speed;
            if(horizontalMove < 0 && !facingRight)
            {
                Flip();
            }
          
            animator.SetBool(IsWalkingParamName, true);
        }
        else if (moveRight)
        {
            horizontalMove = speed;
            if(horizontalMove > 0 && facingRight)
            {
                Flip();
            }
            animator.SetBool(IsWalkingParamName, true);
        }
        else
        {
            horizontalMove = 0;
            animator.SetBool(IsWalkingParamName, false);
        }
    }
    private void FixedUpdate()
    {
        rig2D.velocity = new Vector2(horizontalMove, rig2D.velocity.y); 
    }
    void Flip()
    {      
            facingRight = !facingRight;         
            Vector3 theScale = transform.localScale;         
            theScale.x *= -1;           
            transform.localScale = theScale;
    }
}
