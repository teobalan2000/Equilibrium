using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rigidBody;
    public Joystick jsMovement;
    public Joystick jsWeapon;
    public Animator animator;
    float horizontalMove = 0f;
    bool faceingLeft = true;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        animator = GameObject.Find("BodyPlayer").GetComponent<Animator>();
        
       
    }

    void Update()
    {
        horizontalMove = jsMovement.Horizontal * moveSpeed;


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
        

        rigidBody.velocity = new Vector2(jsMovement.Horizontal * moveSpeed, jsMovement.Vertical * moveSpeed);
    }

    
    void flipPlayer()
    {
        faceingLeft = !faceingLeft;
        Vector3 scale = GameObject.Find("Body").transform.localScale;
        scale.x *= -1;
        GameObject.Find("Body").transform.localScale = scale;
    }
}
