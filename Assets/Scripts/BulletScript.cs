using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour 
{

    public float range = 25f;
    public int damageBullet;

    void Start()
    {
        damageBullet = StateController.WeaponDamage;
    }

    void Update()
    {
        //Debug.Log(damageBullet);
        Destroy(gameObject,2f);
    }
    

    private void OnTriggerEnter2D(Collider2D collider)
    {
        DamageInterface hit = collider.GetComponent<DamageInterface>();
        if (collider.gameObject.tag == "Enemy")
        {
           // Debug.Log("Hit Enemy");
            Destroy(gameObject);

            Vector2 direction = (collider.transform.position - transform.position).normalized;

            hit.OnHit(damageBullet);
        }
    }
}
