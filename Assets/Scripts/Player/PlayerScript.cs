using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CharacterController characterController;
    public float playerSpeed = 5.0f;
    public Joystick js;
    public int MaxHealth = 100;
    public int CurrentHealth;
    private Animator animator;
    public GameObject bullet;
    public Transform firePoint;
    public HealthBar healthBar;

    public void Start()
    {
        animator = GetComponent<Animator>();
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            shoot();
            TakeDamage(20);
        }
        Vector3 move = new Vector3(js.Horizontal, 0, js.Vertical);

        characterController.Move(move * Time.deltaTime * playerSpeed);
    }

    void shoot()
    {
        Instantiate(bullet, firePoint.position, Quaternion.identity);
        Debug.Log("shoot");
    }

    void TakeDamage (int damage)
    {
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
        Debug.Log(CurrentHealth);
    }
}
