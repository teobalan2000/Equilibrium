using System.Collections;
using System.Collections.Generic;
//using Firebase.Database;
using UnityEngine;

public class DamageCharacter : MonoBehaviour , DamageInterface
{
    // Start is called before the first frame update
    private Rigidbody2D rb;

    public int CurrentHealth;
    public int MaxHealth;
    public HealthBar healthBar;
    public GameObject playerDied;
    public LvlScript lvlScript;
    public int EnemyHealth;


    private string userId;
    //private DatabaseReference dbReference;
    //public float EnemyExperiencePoint = 10f;


    void Start()
    {
        if (gameObject.tag == "Enemy")
        {
            CurrentHealth = EnemyHealth;
        }
        else
        {
            MaxHealth = StateController.Health;
            healthBar.SetMaxHealth(MaxHealth);
            healthBar.SetHealth(MaxHealth);
            CurrentHealth = MaxHealth;
            if (gameObject.tag == "Enemy 1")
            {
                CurrentHealth = 100;
            }
        }
        rb = GetComponent<Rigidbody2D>();

        userId = SystemInfo.deviceUniqueIdentifier;
        //dbReference = FirebaseDatabase.DefaultInstance.RootReference;


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
                        StateController.Coins += ScoreManager.myScore;
                        //dbReference.Child("users").Child(userId).Child("Coins").SetValueAsync(StateController.Coins.ToString());
                    }
                }
            }
        }
    }

}
