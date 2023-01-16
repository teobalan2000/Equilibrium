using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageBullet : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 5;
    public Animator animator;

    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwShots <= 0)
        {
            Instantiate(projectile,transform.position,Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots-= Time.deltaTime;
        }
    }

    public float knockBackForce = 50f;

    /*private void OnTriggerEnter2D(Collider2D collider)
    {
        //Debug.Log("Hit");

        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collider.gameObject.tag == "Player")
        {
            animator.SetBool("attack", true);
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            hit.OnHit(damage, knockBack);

        }

    }
    private void OnTriggerStay2D(Collider2D collider)
    {
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collider.gameObject.tag == "Player")
        {
            animator.SetBool("attack", true);
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            hit.OnHit(damage, knockBack);

        }
    }*/
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
