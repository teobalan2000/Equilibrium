using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public int MaxHealth = 100;
    public int CurrentHealth;
    public HealthBar healthBar;
    public NavMeshAgent enemy;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        //enemy.transform.position.y = 0f;
        enemy.updateRotation = false;
        CurrentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(Player.position);
    }
    void TakeDamage(int damage)
    {

        CurrentHealth -= damage;
        healthBar.SetHealth(CurrentHealth);
        Debug.Log(CurrentHealth);
    }
}
