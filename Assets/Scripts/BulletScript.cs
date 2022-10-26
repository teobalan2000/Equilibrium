using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    //public GameObject bullet;
    public float range = 25f;
    // Start is called before the first frame update
    void Start()
    {
        //bullet = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
            Destroy(gameObject,2f);
    }
}
