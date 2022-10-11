using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public CharacterController characterController;
    public float playerSpeed = 5.0f;
    public Joystick js;
    public float health = 100.0f;
    private Animator animator;
    public GameObject bullet;
    public Transform firePoint;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            shoot();
        }
        Vector3 move = new Vector3(js.Horizontal, 0, js.Vertical);

        characterController.Move(move * Time.deltaTime * playerSpeed);
    }

    void shoot()
    {
        Instantiate(bullet, firePoint.position, Quaternion.identity);
        Debug.Log("shoot");
    }
}
