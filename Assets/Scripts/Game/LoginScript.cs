using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LoginScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject loginPanel;
    public GameObject RegisterPanel;

    public InputField UserNameLogin;
    public InputField PasswordLogin;
    public InputField UserNameRegister;
    public InputField PasswordRegister;


    void Start()
    {
        RegisterPanel.SetActive(false);
        loginPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoginButton()
    {
        SceneManager.LoadScene("MainMenuScene");
    }

    public void RegisterButton()
    {
        RegisterPanel.SetActive(true);
        loginPanel.SetActive(false);
    }

    public void createAccount()
    {
        RegisterPanel.SetActive(false);
        loginPanel.SetActive(true);
    }
}
