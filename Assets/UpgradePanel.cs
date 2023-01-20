using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradePanel : MonoBehaviour
{
    public Button healthUpgradeButton;
    public Database db;

    public Text coinsText;
    public Text playerHealth;
    public Text playerDamage;
    public Text playerFireRate;

    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(StateController.Health);
        //coinsText.text = StateController.Coins.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHealth.text = "Player: " + StateController.Health.ToString();
        playerDamage.text = "Player: " + StateController.WeaponDamage.ToString();
        playerFireRate.text = "Player: " + StateController.FireRate.ToString("F2");
        coinsText.text = "Coins: " +StateController.Coins.ToString();
    }

    public void UpgradeHealth()
    {
        if (StateController.Coins >= 50 && StateController.Health < 300)
        {
        StateController.Health += 50;
            //db.dbReference.Child("users").Child(db.userId).Child("Health").SetValueAsync(StateController.Health.ToString());
            StateController.Coins -= 50;
            //db.dbReference.Child("users").Child(db.userId).Child("Coins").SetValueAsync(StateController.Coins.ToString());
            //db.GetCoinsOfUser();
            //coinsText.text = StateController.Coins.ToString();
            //playerHealth.text ="Player: " + StateController.Health.ToString();
        }
        else if(StateController.Health == 300)
        {
            
        }
    }

    public void UpgradeDamage()
    {
        if (StateController.Coins >= 100 && StateController.WeaponDamage < 100)
        {
            StateController.WeaponDamage += 10;
            //db.dbReference.Child("users").Child(db.userId).Child("WeaponDamage").SetValueAsync(StateController.WeaponDamage.ToString());
            StateController.Coins -= 100;
            //db.dbReference.Child("users").Child(db.userId).Child("Coins").SetValueAsync(StateController.Coins.ToString());
            //db.GetCoinsOfUser();
            //coinsText.text = "Coins: "StateController.Coins.ToString();
            //playerDamage.text ="Player: " + StateController.WeaponDamage.ToString();
        }
        else if (StateController.WeaponDamage == 100)
        {

        }
    }

    public void UpgradeFireRate()
    {
        if (StateController.Coins >= 150 && StateController.FireRate > 0.1)
        {
            //float firerate = StateController.FireRate - 0.1f;
            StateController.FireRate -= 0.1f; 
            //StateController.FireRate = Mathf.Round((StateController.FireRate * 10.0f) * 0.1f);
            //db.dbReference.Child("users").Child(db.userId).Child("FireRate").SetValueAsync(StateController.FireRate.ToString());
            StateController.Coins -= 150;
            //db.dbReference.Child("users").Child(db.userId).Child("Coins").SetValueAsync(StateController.Coins.ToString());
            //db.GetCoinsOfUser();
            //coinsText.text = StateController.Coins.ToString();
            //playerFireRate.text ="Player: " + StateController.FireRate.ToString();
        }
        else if (StateController.WeaponDamage == 0.1)
        {

        }
    }
}
