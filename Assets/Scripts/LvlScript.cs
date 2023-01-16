using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LvlScript : MonoBehaviour
{
    public int Lvl = 0;
    public float currentXp;
    public float requiredXp = 120;

    public Image LvlBarImage;
    public Text lvlText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            GetExperience(20);
        }
    }
    private float givenXp;
    // Update is called once per frame

    public void GetExperience(float experienceGained)
    {
        //float xpFraction = currentXp / requiredXp;
        //float FXP = LvlBarImage.fillAmount;


        if (currentXp >= requiredXp)
        {
            currentXp = currentXp - requiredXp;
            Lvl ++;
        }
        else
        {
            //Debug.Log(experienceGained);
            currentXp += experienceGained;
        }
        LvlBarImage.fillAmount = currentXp;
        lvlText.text = Lvl.ToString();
    }
}
