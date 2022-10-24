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
    public Animator animator;
    public GameObject bullet;
    public Transform firePoint;
    public HealthBar healthBar;
    bool faceingLeft = true;
    public void Start()
    {
        animator = GetComponent<Animator>();
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }
    float horizontalMove = 0f;
    void Update()
    {
        horizontalMove = js.Horizontal * playerSpeed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
        
        if(horizontalMove > 0 && faceingLeft)
        {
            flipPlayer();
        }
        else if(horizontalMove < 0 && !faceingLeft)
        {
            flipPlayer();
        }


        if(Input.GetKeyDown("space"))
        {
            shoot();
            //TakeDamage(20);
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

    void flipPlayer()
    {
        faceingLeft = !faceingLeft;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
