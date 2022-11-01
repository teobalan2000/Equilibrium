using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{
    //public GameObject bullet;
    public float range = 25f;
    public int damageBullet = 10;
    // Start is called before the first frame update
    void Start()
    {
        //bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
            Destroy(gameObject,2f);
    }
    public float knockBackForce = 1000f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D collider = collision.collider;
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
            //Debug.Log("Hit");
            Vector2 direction = (collider.transform.position - transform.position).normalized;

            Vector2 knockBack = direction * knockBackForce;
            //playerHealth.TakeDamage(damage);
            hit.OnHit(damageBullet, knockBack);
        }
    }
}
