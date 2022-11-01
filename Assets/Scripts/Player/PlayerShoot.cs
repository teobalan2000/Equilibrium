using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Joystick js;
    public Transform firePoint;
    public GameObject bulletPref;

    public float bulletForce = 20f;
    public float fireRate = 0.5f;
    public float nextFire = 0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(js.Horizontal != 0)
        {
           // yield return new WaitForSeconds(2f);
            Shoot();
        }
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
