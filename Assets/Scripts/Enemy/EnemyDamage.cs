using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float knockBackForce = 5000f; 
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if(collision.gameObject.tag == "Player")
        {
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            hit.OnHit(damage,knockBack);
        }
    }
    
}
