using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    [SerializeField]
    private float shiftModifier = 1f;

    private Gyroscope gyro;

    // Start is called before the first frame update
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((float)System.Math.Round(gyro.rotationRateUnbiased.y, 1) * shiftModifier, (float)System.Math.Round(gyro.rotationRateUnbiased.x, 1) * shiftModifier, 0f);
        //transform.Translate((float)System.Math.Round(gyro.rotationRateUnbiased.x, 1) * shiftModifier, 0f, 0f);
    }
}
