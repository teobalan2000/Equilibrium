using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public GameObject upgrades;
    public GameObject startPanel;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        player.SetActive(true);
        upgrades.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayButton()
    {
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
}
