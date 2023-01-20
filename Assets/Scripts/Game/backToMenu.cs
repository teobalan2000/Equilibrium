using System.Collections;
using System.Collections.Generic;
//using Firebase.Database;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    //Database db;
    //ScoreManager sm;
    // Start is called before the first frame update
    //private string userId;
    //private DatabaseReference dbReference;
    void Start()
    {
        //userId = SystemInfo.deviceUniqueIdentifier;
        //dbReference = FirebaseDatabase.DefaultInstance.RootReference;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackButton()
    {
        if(StateController.HighScore < ScoreManager.myScore)
        {
            StateController.HighScore = ScoreManager.myScore;
            //UpdateHighScore();
        }
        
        SceneManager.LoadScene("MainMenuScene");
        //db.CreateUser(sm.HighScore);
    }


    //public void UpdateHighScore()
    //{
    //    dbReference.Child("users").Child(userId).Child("HighScore").SetValueAsync(StateController.HighScore.ToString());
    //}
}
