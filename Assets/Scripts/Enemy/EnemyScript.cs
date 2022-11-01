using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour 
{
    public GameObject target;
    private Rigidbody2D rb;
    public float moveSpeed = 3f;
    Vector2 movement;
    bool facingRight = true;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();


    }
    private float xir = 0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        
        Vector3 direction = target.transform.position - transform.position;
       
        
        direction.Normalize();
        movement = direction;
        rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    }

   
}
