using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{

    public float range = 25f;
    public int damageBullet = 10;

    void Start()
    {

    }

    void Update()
    {
            Destroy(gameObject,2f);
    }
    public float knockBackForce = 5f;
    private void OnCollisionEnter2D(Collision2D collision)
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
    }
}
