using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Text healthText;

    public void Start()
    {
        //Debug.Log(slider.value);
        //slider.value = StateController.Health;
        //Debug.Log(StateController.Health);
    }

    public void SetMaxHealth(int health)
    {
        //Debug.Log(health);
        healthText.text = health.ToString();
        slider.maxValue = health;
        //Debug.Log(slider.maxValue);
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
        if(health <= 0)
        {
            health = 0;
            
        }
        healthText.text = health.ToString();
    }

}
