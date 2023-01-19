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
    public GameObject playerDied;
    public LvlScript lvlScript;
    //public float EnemyExperiencePoint = 10f;

    
    void Start()
    {
        CurrentHealth = MaxHealth;
        rb = GetComponent<Rigidbody2D>();
       
    }

    public void OnHit(int damage)
    {
        //rb.AddForce(knockBack, ForceMode2D.Impulse);

        CurrentHealth -= damage;
        if (gameObject.tag == "Player")
        {
            healthBar.SetHealth(CurrentHealth);
        }
        
        

        if (CurrentHealth <= 0)
        {
            if (gameObject != null)
            {
                if (gameObject != null)
                {
                    Destroy(gameObject);

                    ScoreManager.myScore++;
                    //lvlScript.GetExperience(EnemyExperiencePoint);
                    //lvlScript.GetExperience(30);
                    if (gameObject.tag == "Player")
                    {
                        playerDied.SetActive(true);
                    }
                }
            }
        }
    }

}
