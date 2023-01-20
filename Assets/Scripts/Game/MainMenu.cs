using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject startPanel;
    public GameObject player;

    public GameObject audioOn;
    public GameObject audioOff;


    public Text score;
    public Text coins;

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        player.SetActive(true);
        upgrades.SetActive(false);
        audioOff.SetActive(false);
        audioOn.SetActive(true);
        if (StateController.HighScore == -1 && StateController.Coins == -1 && StateController.Health == -1 && StateController.WeaponDamage == -1 && StateController.FireRate == -1)
        {
            Debug.Log("START!!!");
            StateController.HighScore = 0;
            StateController.Coins = 1000;
            StateController.Health = 50;
            StateController.WeaponDamage = 20;
            StateController.FireRate = 1f;
        }
            score.text = "Hishscore: " + StateController.HighScore.ToString();
            coins.text = "Coins: " + StateController.Coins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
        startPanel.SetActive(false);
        SceneManager.LoadScene("GameScene");
    }

    public void Upgrade()
    {
        startPanel.SetActive(false);
        upgrades.SetActive(true);
        player.SetActive(false);
    }

    public void ExitUpgrades()
    {
        upgrades.SetActive(false);
        startPanel.SetActive(true);
        player.SetActive(true);
    }


    public void MuteAudio(bool mute)
    {
        if (mute)
        {
            AudioListener.volume = 0;
            audioOff.SetActive(true);
            audioOn.SetActive(false);
        }

        else
        {
            AudioListener.volume = 1;
            audioOff.SetActive(false);
            audioOn.SetActive(true);
        }
    }
}
