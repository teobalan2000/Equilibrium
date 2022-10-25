using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public float smoothnes = 0.125f;
    public Vector3 offSet;
    void Start()
    {
        offSet.z = -10f;
        //player = GameObject.Find("Player");
    }


    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offSet;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothnes);
        transform.position = smoothedPosition;
    }
}
