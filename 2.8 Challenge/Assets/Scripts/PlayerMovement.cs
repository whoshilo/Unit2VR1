using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    Vector2 xMove;
    Transform player;
    float xMovement;
    float yMovement;
    public float Speed = 4.0f;
    Rigidbody2D rb2d;
    public float thrust = 4.0f;
    bool jump;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        rb2d = GetComponent<Rigidbody2D>();
        health = 3;
        
    }

    // Update is called once per frame
    void Update()
    {


        xMovement = Input.GetAxis("Horizontal");
        yMovement = Input.GetAxis("Vertical");
        xMove = new Vector2(xMovement, yMovement);
        player.Translate(xMove * Speed);


        if (xMovement > 0)
        {
            player.localScale = new Vector3(4, 4, 1);
        }
        if (xMovement < 0)
        {
            player.localScale = new Vector3(-4, 4, 1);
        }

        animator.SetFloat("Speed", Mathf.Abs(xMovement));
    
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
        if(health == 0)
        {
            Debug.Log("GAME OVER!");
        }

        
    }
       
   
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground") 
        {
            animator.SetBool("jump", false);
        }
        else
        {
            animator.SetBool("jump", true);
        }

        if (col.gameObject.tag == "Acorn")
        {
            Debug.Log("NOM NOM NOM");
        }
        if (col.gameObject.tag == "Enemy")
        {
            Debug.Log("OUCH");
            health = health - 1;
        }
    }
    void OnBecameInvisible()
    {
        health = 0;
        Destroy(gameObject);
    }

    [SerializeField] private string newLevel;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("FinalAcorn"))
        {
            SceneManager.LoadScene(newLevel);
        }
    }
}
