using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text Score;
    public static int myScore;
 

    // Start is called before the first frame update
    void Start()
    {
        myScore = 0;
        Score.text = "Score:" + myScore;
        
    }

    void Update()
    {
        Score.text = "Score:" + myScore;
    }


}
