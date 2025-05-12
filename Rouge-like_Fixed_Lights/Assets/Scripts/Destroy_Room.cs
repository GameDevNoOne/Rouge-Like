using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Room : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SpawnPoint"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.CompareTag("ClosedRoom"))
        {
            Destroy(collision.gameObject);
        }
    }

    public void FixedUpdate()
    {
        gameObject.transform.position = GetComponentInParent<Transform>().transform.position; 
    }
}
