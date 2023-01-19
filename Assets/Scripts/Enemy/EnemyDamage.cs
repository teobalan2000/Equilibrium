using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 5;
    public Animator animator;

    private float timeBtwAttack;
    public float startTimeBtwAttack;
    // Start is called before the first frame update
    void Start()
    {
       animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float knockBackForce = 50f;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Hit");

        //DamageInterface hit = collider.GetComponent<DamageInterface>();
        //if (collider.gameObject.tag == "Player")
        //{
        //    animator.SetBool("attack", true);
        //    Vector2 direction = (collider.transform.position - transform.position).normalized;

        //    Vector2 knockBack = direction * knockBackForce;
        //    //playerHealth.TakeDamage(damage);
        //    hit.OnHit(damage, knockBack);

        //}

    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collider.gameObject.tag == "Player")
        {
            if (timeBtwAttack <= 0)
            {
                animator.SetBool("attack", true);
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            
                hit.OnHit(damage, knockBack);
                timeBtwAttack = startTimeBtwAttack;
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
            }

        }
    }
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if(collision.gameObject.tag == "Player")
        {
            animator.SetBool("attack", true);
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            hit.OnHit(damage,knockBack);
            
        }
        //animator.SetBool("attack", false);
    }
    */

}
