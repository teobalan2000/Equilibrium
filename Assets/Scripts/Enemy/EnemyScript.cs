using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour 
{
    public GameObject target;
    private Rigidbody2D rb;
    public float moveSpeed = 3f;
    Vector2 movement;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();


    }


    void FixedUpdate()
    {
        
        Vector3 direction = target.transform.position - transform.position;
       
        
        direction.Normalize();
        movement = direction;
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

   
}
