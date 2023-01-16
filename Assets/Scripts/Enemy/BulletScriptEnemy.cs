using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriptEnemy : MonoBehaviour 
{

    public float range = 25f;
    public int damageBullet = 10;

    public float speed;
    private Transform player;
    private Vector2 target;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        
        Destroy(gameObject, 3f);
    }
    public float knockBackForce = 5f;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collider.gameObject.tag == "Player")
        {
            Debug.Log("Hit Player");
            Destroy(gameObject);

            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;

            hit.OnHit(damageBullet, knockBack);
        }
    }
   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);

            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;

            hit.OnHit(damageBullet, knockBack);
        }
    }*/
}
