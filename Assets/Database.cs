using System;
using System.Collections;
using System.Collections.Generic;
using Firebase.Database;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class Database : MonoBehaviour
{
    
    public Text HighScore;
    
    private string userId;
    private DatabaseReference dbReference;
    // Start is called before the first frame update
    void Start()
    {
        userId = SystemInfo.deviceUniqueIdentifier;
        dbReference = FirebaseDatabase.DefaultInstance.RootReference;
        //CreateUser(100);
        GetUserInfo();
        //Debug.Log(dbReference.Child("users").Child(userId).GetValueAsync().ToString())
    }

    
    

    public void CreateUser(int score)
    {
        User newUser = new User(score);
        string json = JsonUtility.ToJson(newUser);

        dbReference.Child("users").Child(userId).SetRawJsonValueAsync(json);
    }

    public IEnumerator GetHighScore(Action<int> onCallback)
    {
        var userHighScoreData = dbReference.Child("users").Child(userId).Child("HighScore").GetValueAsync();

        yield return new WaitUntil(predicate: () => userHighScoreData.IsCompleted);

        if(userHighScoreData != null)
        {
            DataSnapshot snapshot = userHighScoreData.Result;

            onCallback.Invoke(int.Parse(snapshot.Value.ToString()));
        }

    }

    public void GetUserInfo()
    {
        StartCoroutine(GetHighScore((int highScore) => {
            HighScore.text = "Highscore: " + highScore.ToString();
        }));
    }
}
