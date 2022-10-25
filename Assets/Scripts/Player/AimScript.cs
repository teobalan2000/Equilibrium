using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimScript : MonoBehaviour
{
    public Joystick jsWeapon;
    public Transform aimTransform;
    private void Awake()
    {
        aimTransform = transform.Find("Aim");
    }

    private void Update()
    {
        float angle = Mathf.Atan2(jsWeapon.Vertical, jsWeapon.Horizontal) * Mathf.Rad2Deg;

        aimTransform.eulerAngles = new Vector3(0, 0, angle);

        Vector3 localScale = Vector3.one;
        if(angle > 90 || angle < -90)
        {
            localScale.y = -1f;
        }
        else
        {
            localScale.y = +1f;
        }
        aimTransform.localScale = localScale;

    }
}
