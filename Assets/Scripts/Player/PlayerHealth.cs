using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int CurrentHealth;
    public static int MaxHealth = 100;
    public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
    }

    public void TakeDamage(int damage)
    {
        //health -= amount;
        //if(health <= 0)
        //{
        //    Destroy(gameObject);
        //}
        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
        Debug.Log(CurrentHealth);
    }
}
