using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{
    Transform player;
    public Animator animator;
    public float speed;
    public float jump;

    private float move;
    private Rigidbody2D rb;
    private bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            isJumping = true;
        }

        if (move > 0)
        {
            player.localScale = new Vector3(1, 1, 1);
        }
        if (move < 0)
        {
            player.localScale = new Vector3(-1, 1, 1);
        }

        animator.SetFloat("Speed", Mathf.Abs(move));


        if (Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if (isJumping == false)
        {
            animator.SetBool("jump", false);
        }

        if (isJumping == true)
        {
            animator.SetBool("jump", true);
        }
    }
    void OnCollisionEnter2D (Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
   
    
    
    }  
}
