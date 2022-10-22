using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraScript : MonoBehaviour
{

    public Transform player;
    public float smoothnes = 0.125f;
    public Vector3 offSet;
    void Start()
    {
        offSet.y = 6.5f;
        offSet.z = -6.5f;
        //player = GameObject.Find("Player");
    }

    
    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offSet;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothnes);
        transform.position = smoothedPosition;
    }
}
