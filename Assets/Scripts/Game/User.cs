using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User
{
    public int HighScore;
    public int Coins;
    public int Health;
    public int WeaponDamage;
    public float FireRate;

    public User(int HighScore,int Coins, int Health, int WeaponDamage, float FireRate)
    {
        this.HighScore = HighScore;
        this.Coins = Coins;
        this.Health = Health;
        this.WeaponDamage = WeaponDamage;
        this.FireRate = FireRate;
    }
}
