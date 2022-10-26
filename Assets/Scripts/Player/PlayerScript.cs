using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Joystick jsMovement;
    public Joystick jsWeapon;
    public Animator animator;
    float horizontalMove = 0f;
    bool faceingLeft = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GameObject.Find("BodyPlayer").GetComponent<Animator>();
        
       
    }
    Vector2 movement;
    void Update()
    {
        horizontalMove = jsMovement.Horizontal * moveSpeed;
        movement.x = jsMovement.Horizontal;
        movement.y = jsMovement.Vertical;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        
        if (jsWeapon.Horizontal == 0)
        {
            if (horizontalMove > 0 && faceingLeft)
            {
                flipPlayer();
            }
            else if (horizontalMove < 0 && !faceingLeft)
            {
                flipPlayer();
            }
        }
        else
        {
            if (jsWeapon.Horizontal > 0 && faceingLeft)
            {
                flipPlayer();
            }
            else if (jsWeapon.Horizontal < 0 && !faceingLeft)
            {
                flipPlayer();
            }
        }
        
        
       
    }

    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    void flipPlayer()
    {
        faceingLeft = !faceingLeft;
        Vector3 scale = GameObject.Find("BodyPlayer").transform.localScale;
        scale.x *= -1;
        GameObject.Find("BodyPlayer").transform.localScale = scale;
    }
}
