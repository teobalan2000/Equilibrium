using System;
using System.Collections;
using System.Collections.Generic;
//using Firebase.Database;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Database : MonoBehaviour
{

    //public Text HighScore;
    //public Text Coins;

    //public string userId;
    //public DatabaseReference dbReference;
    // Start is called before the first frame update
    void Start()
    {
        //userId = SystemInfo.deviceUniqueIdentifier;
        //dbReference = FirebaseDatabase.DefaultInstance.RootReference;
        //CreateUser(0,0,50,20,1f);
        //GetUserInfo();
        //GetCoinsOfUser();
        //Debug.Log(dbReference.Child("users").Child(userId).GetValueAsync().ToString())
    }




    //public void CreateUser(int score,int Coins , int Health , int WeaponDamage , float FireRate)
    //{
    //    User newUser = new User(score,Coins,Health,WeaponDamage,FireRate);
        
    //    string json = JsonUtility.ToJson(newUser);

    //    dbReference.Child("users").Child(userId).SetRawJsonValueAsync(json);
    //}

    //public IEnumerator GetHighScore(Action<int> onCallback)
    //{
    //    var userHighScoreData = dbReference.Child("users").Child(userId).Child("HighScore").GetValueAsync();

    //    yield return new WaitUntil(predicate: () => userHighScoreData.IsCompleted);

    //    if (userHighScoreData != null)
    //    {
    //        DataSnapshot snapshot = userHighScoreData.Result;

    //        onCallback.Invoke(int.Parse(snapshot.Value.ToString()));
    //    }

    //}

    
    //public IEnumerator GetCoins(Action<int> onCallback)
    //{
    //    var userCoinsData = dbReference.Child("users").Child(userId).Child("Coins").GetValueAsync();

    //    yield return new WaitUntil(predicate: () => userCoinsData.IsCompleted);

    //    if (userCoinsData != null)
    //    {
    //        DataSnapshot snapshot = userCoinsData.Result;

    //        onCallback.Invoke(int.Parse(snapshot.Value.ToString()));
    //    }

    //}

    //public IEnumerator GetHealth(Action<int> onCallback)
    //{
    //    var userHealthData = dbReference.Child("users").Child(userId).Child("Health").GetValueAsync();

    //    yield return new WaitUntil(predicate: () => userHealthData.IsCompleted);

    //    if (userHealthData != null)
    //    {
    //        DataSnapshot snapshot = userHealthData.Result;

    //        onCallback.Invoke(int.Parse(snapshot.Value.ToString()));
    //    }

    //}


    //public IEnumerator GetWeaponDamage(Action<int> onCallback)
    //{
    //    var userWeaponData = dbReference.Child("users").Child(userId).Child("WeaponDamage").GetValueAsync();

    //    yield return new WaitUntil(predicate: () => userWeaponData.IsCompleted);

    //    if (userWeaponData != null)
    //    {
    //        DataSnapshot snapshot = userWeaponData.Result;

    //        onCallback.Invoke(int.Parse(snapshot.Value.ToString()));
    //    }

    //}

    //public IEnumerator GetFireRate(Action<float> onCallback)
    //{
    //    var userFireRateData = dbReference.Child("users").Child(userId).Child("FireRate").GetValueAsync();

    //    yield return new WaitUntil(predicate: () => userFireRateData.IsCompleted);

    //    if (userFireRateData != null)
    //    {
    //        DataSnapshot snapshot = userFireRateData.Result;

    //        onCallback.Invoke(float.Parse(snapshot.Value.ToString()));
    //    }

    //}

    //public void GetUserInfo()
    //{
    //    StartCoroutine(GetHighScore((int highScore) =>
    //    {
    //        HighScore.text = "Highscore: " + highScore.ToString();
    //        StateController.HighScore = highScore;
    //    }));

    //    //StartCoroutine(GetCoins((int coins) =>
    //    //{
    //    //    Coins.text = "Coins: " + coins.ToString();
    //    //    StateController.Coins = coins;
    //    //}));

    //    StartCoroutine(GetHealth((int health) =>
    //    {
    //        StateController.Health = health;
    //    }));

    //    StartCoroutine(GetWeaponDamage((int damageWe) =>
    //    {
    //        StateController.WeaponDamage = damageWe;
    //    }));

    //    StartCoroutine(GetFireRate((float fireRate) =>
    //    {
    //        StateController.FireRate = fireRate;
    //    }));
    //}

    //public void GetCoinsOfUser()
    //{
    //    StartCoroutine(GetCoins((int coins) =>
    //    {
    //        Coins.text = "Coins: " + coins.ToString();
    //        StateController.Coins = coins;
    //    }));
    //}
}
