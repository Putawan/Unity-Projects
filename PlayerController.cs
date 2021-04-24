using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private Animator anim;
    private float moveSpeed;
    private float directionX;
    private bool canJump = true;
    private Vector3 localScale;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        moveSpeed = 5f;
    }

    // Update is called once per frame
    private void Update()
    {
        directionX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;

        if (directionX < 0)
        {
            rb.velocity = new Vector2(-5, rb.velocity.y);
            transform.localScale = new Vector2(-1, 1);
            anim.SetBool("running", true);
        }

        else if (directionX > 0)
        {
            rb.velocity = new Vector2(5, rb.velocity.y);
            transform.localScale = new Vector2(1, 1);
            anim.SetBool("running", true);
        }

        else 
        {
            anim.SetBool("running", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (canJump)
            {
                rb.velocity = new Vector2(rb.velocity.x, 11f);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            canJump = false;
        }
    }
}

