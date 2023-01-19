using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour 
{
    public GameObject target;
    //private Rigidbody2D rb;
    public float moveSpeed = 3f;
    Vector2 movement;
    //public Transform enemy;
    public float minDistance = -1;
    private Animator animator;
    bool faceingLeft = true;
    private float time = 0f, Delay = 2f;

    //public float enemyExperiencePoint = 10f;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        //rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        //animator.SetBool("popIn", true);
    }

    private void Update()
    {
        time = time + 1f * Time.deltaTime;
        if (time > Delay && target != null)
        {
            //animator.SetBool("popIn", false);
            if (transform.position.x > target.transform.position.x && faceingLeft == false)
            {
                flipPlayer();
            }
            else if (transform.position.x < target.transform.position.x && faceingLeft == true)
            {
                flipPlayer();
            }
            if (Vector2.Distance(transform.position, target.transform.position) > minDistance)
            {
                animator.SetBool("isMoving", true);
                transform.position = Vector2.MoveTowards(transform.position, target.transform.position, moveSpeed * Time.deltaTime);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
        }
    }

   

    void flipPlayer()
    {
        faceingLeft = !faceingLeft;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
        //GameObject.Find("BodyPlayer").transform.localScale = scale;
    }

    //void FixedUpdate()
    //{
    //    Vector3 direction = target.transform.position - transform.position;
    //    direction.Normalize();
    //    movement = direction;
    //    //rb.MovePosition((Vector2)transform.position + (movement * moveSpeed * Time.fixedDeltaTime));
    //}


}
