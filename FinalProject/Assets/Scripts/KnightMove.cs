using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightMove : MonoBehaviour
{
    public Animator animator;
    Vector2 xMove;
    Transform player;
    float Xmovement;
    float Ymovement;
    public float Speed = 4.0f;
    public float thrust = 4.0f;
    Rigidbody2D rb2d;
    bool jump;
    private bool isJumping;

    void Start()
    {
        player = gameObject.transform;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Xmovement = Input.GetAxis("Horizontal");
        Ymovement = Input.GetAxis("Vertical");
        xMove = new Vector2(Xmovement, Ymovement);
        player.Translate(xMove * Time.deltaTime);

        if (Xmovement > 0)
        {
            player.localScale = new Vector3(1, 1, 1);
        }
        if (Xmovement < 0)
        {
            player.localScale = new Vector3(-1, 1, 1);
        }

        animator.SetFloat("Speed", Mathf.Abs(Xmovement));

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.AddForce(transform.up * thrust);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }

        if (jump == false)
        {
            animator.SetBool("jump", false);
        }

        if (jump == true)
        {
            animator.SetBool("jump", true);
        }
        
    }

}
