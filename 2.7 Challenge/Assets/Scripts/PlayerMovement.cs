using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    public int speed = 4;
    bool jump = false;
    bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        

        xMovement = Input.GetAxis("Horizontal");
        yMovement = Input.GetAxis("Vertical");
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove * Time.deltaTime);

        if (xMovement > 0)
        {
            player.localScale = new Vector3(6, 6, 1);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-6, 6, 1);
        }

         animator.SetFloat("Speed", Mathf.Abs(xMovement));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("IsJumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
            
        
    }   
    public void OnLanding ()
    {
        animator.SetBool("IsJumping", false);
    }
}