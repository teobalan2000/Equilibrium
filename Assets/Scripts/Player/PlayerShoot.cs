using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Joystick js;
    public Transform firePoint;
    public GameObject bulletPref;

    public Animator animator;

    public float bulletForce = 20f;
    public float fireRate = 0.5f;
    public float nextFire = 0f;
    void Start()
    {
        fireRate = StateController.FireRate;
        //animator = GameObject.Find("Character (96)").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(js.Horizontal != 0 || js.Vertical != 0)
        {
           // yield return new WaitForSeconds(2f);
            Shoot();
           // animator.SetBool("isMoving", true);

        }
       // animator.SetBool("isMoving", false);
        /*
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        */

    }

    void Shoot()
    {
        if (Time.time > nextFire)
        {
            
            nextFire = Time.time + fireRate;
            GameObject bullet = Instantiate(bulletPref, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.AddForce(firePoint.right * bulletForce, ForceMode2D.Impulse);
        }
    }
}
