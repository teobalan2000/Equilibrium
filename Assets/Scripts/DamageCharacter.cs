using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCharacter : MonoBehaviour , DamageInterface
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    public int CurrentHealth;
    public int MaxHealth = 100;
    public HealthBar healthBar;

    void Start()
    {
        CurrentHealth = MaxHealth;
        rb = GetComponent<Rigidbody2D>();
       
    }

    public void OnHit(int damage,Vector2 knockBack)
    {
        rb.AddForce(knockBack, ForceMode2D.Impulse);

        CurrentHealth -= damage;
        if (gameObject.tag == "Player")
        {
            healthBar.SetHealth(CurrentHealth);
        }
        
        

        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}
