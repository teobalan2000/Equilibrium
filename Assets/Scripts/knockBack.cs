using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knockBack : MonoBehaviour
{

    public float thrust = 1f;
    // Start is called before the first frame update
    public GameObject bullet;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Rigidbody2D enemy = other.GetComponent<Rigidbody2D>();
            if (enemy != null)
            {
                enemy.isKinematic = false;
                Vector2 difference = enemy.transform.position - transform.position;
                difference = difference.normalized * thrust;
                enemy.AddForce(difference, ForceMode2D.Impulse);
                enemy.isKinematic = true;
                Destroy(gameObject);
            }
        }
    }
}
