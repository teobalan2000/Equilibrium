using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Joystick jsWeapon;
    public Transform aimTransform;
    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }

    private void Update()
    {
       // Vector3 aimPosMouse = GetMouseWorldPosition();//UtilsClass.GetMouseWorlPosition();
        //Vector3 aimPosJs = new Vector3(jsWeapon.Horizontal, 0f, jsWeapon.Vertical);
        //Debug.Log("mouse point = " + aimPosMouse);
        //Debug.Log("Joystick point = " + aimPosJs);
       // Vector3 aimDirection = (aimPosJs - transform.position).normalized;
        float angle = Mathf.Atan2(jsWeapon.Vertical, jsWeapon.Horizontal) * Mathf.Rad2Deg;
        //Debug.Log(jsWeapon.Vertical + " - " + jsWeapon.Horizontal);
        aimTransform.eulerAngles = new Vector3(45, 0, angle);
        //Debug.Log("Angle = " + angle);
        //Debug.Log("Euler = " + aimTransform.eulerAngles);
    }

}
